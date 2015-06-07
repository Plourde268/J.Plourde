

// REFACTORED

var testIIFE = (function () {
    // local scope to testIIFE
    var name = "Sue";
})();

// IIFE
// Imedialty Invoked Function Expression
var myTodo = (function () {
    var name = "Susan";

    //Our To Do Constructor
    var Todo = function (task, iscompleted) {
        this.task = task,
        this.iscompleted = iscompleted
    }
    //Central Data Container/Array
    var todoArray = [];
    //This variable will keep track of current item
    var currId;

    // firebase base url 
    // needs to be changed if you want to use multiple scripts
    var baseFb = "teamsquirrel";


    var proPic = "http://i0.kym-cdn.com/entries/icons/original/000/000/138/Picture_2.png"
    //"315demo" //

    // Arguments Example.....
    function addNum() {
        var finnum;
        for (var i = 0; i < arguments.length; i++) {
            finnum += arguments[i];
        }
        console.log(finnum);
    }


    // create the URL's for all firebase calls
    function urlMaker() {
        // needs to be changed if you want to a single FB
        var finUrl = "https://" + baseFb + ".firebaseio.com/tweets/";
        for (var i = 0; i < arguments.length; i++) {
            finUrl += arguments[i] + "/";
        }
        finUrl += ".json"
        console.log("URL MAKER: ", finUrl);
        return finUrl;
    }

    // Handle all AJAX methods...
    //@ verb        - HTTP Method (GET, PUT, etc.)
    //@ url         - firebase URL
    //@ data        - object to send to Firebase
    //@ cb_success  - method to call after successfull XHR call
    //@ cb_error    - method to call after an error occurs in the XHR call
    //@ extra       - for future use
    function masterXhr(verb, url, data, cb_success, cb_error, extra) {
        var request = new XMLHttpRequest();
        request.open(verb, url, true);
        request.onload = function () {
            // check if XHR was successfull
            if (this.status >= 200 && this.status < 400) {
                // check if the Callback is a function
                if (typeof cb_success == "function") {
                    // convert the response into an object
                    var res = JSON.parse(this.response);
                    // execute the callback and pass the results as an argument
                    cb_success(res);
                }
            }
            else {
                // XHR was unsuccessfull
                // check if the Callback is a function
                if (typeof cb_error == "function") {
                    // convert the response into an object
                    var resErr = JSON.parse(this.response);
                    // execute the callback and pass the error results as an argument
                    cb_error(resErr);
                }
            }
        };
        // if data was passed as an argument, stringify then send
        if (data) {
            var objToSend = JSON.stringify(data)
            request.send(objToSend);
        } else {
            // no data, just execute the send
            request.send();
        }

    }


    //Fetch data from Firebase 
    var fetch = function () {
        console.log("called fetch");
        masterXhr("GET", urlMaker(), null, showresults, errorCallback);
    }
    fetch();


    //Callback for error
    function errorCallback(data) {
        console.log("SOME ERROR: ", data)
    }

    //Callback for fetch
    function showresults(data) {
        todoArray = []; // reset the data container
        var indexCounter = 0;
        var htmlstr = "";
        for (var i in data) {
            // console.log(data[i].todo, data[i].iscompleted);
            todoArray.push({
                id: i,
                todo: data[i].todo,
                name: data[i].name,
                pic: data[i].pic,
                time: data[i].time
            })

            htmlstr += "<div class='jumbotron'>";
            htmlstr += "<h4><img class='comPic' src='" + data[i].pic + "' /> "+data[i].name+"</h4>" + "<br/>" + data[i].todo;
            //htmlstr += data[i].time;
            htmlstr += "<hr/>"+ data[i].time+"<button onclick='myTodo.dodeletetodo(" + indexCounter + ")' class='btn btn-xs btn-danger pull-right'><span class='glyphicon glyphicon-trash'></span></button>";
            htmlstr += "<button onclick='myTodo.doupdatetodo(" + indexCounter + ")' class='btn btn-xs btn-warning pull-right'><span class='glyphicon glyphicon-erase'></span></button>";
            htmlstr += "</div>";
            indexCounter++;
        }
        htmlstr += "";

        // needs to be changed if you are using multiple scripts
        $("#ToDoList").html(htmlstr);
    }

    function doaddtodo() {
        console.log($("#todotext").val())
        console.log($("#todocompleted").val())
        var newtodo = {
            todo: $("#todotext").val(),
            name: "Justin",
            pic: "http://i0.kym-cdn.com/entries/icons/original/000/000/138/Picture_2.png",
            time: moment().format('L')
        }
        sendToAjax(newtodo)
    }

    // Send object to firebase via AJAX
    function sendToAjax(objToPost) {
        masterXhr("POST", urlMaker(), objToPost, fetch, errorCallback);
    }




    function dodeletetodo(index) {
        //console.log(todoArray[index])
        masterXhr("DELETE", urlMaker(todoArray[index].id), null, fetch, errorCallback)
    }



    //
    $('#savetodo').hide();
    function doupdatetodo(index) {
        console.log(todoArray[index])
        $('#todotext').val(todoArray[index].todo);
        $('#todocompleted').val(todoArray[index].iscompleted);
        currId = todoArray[index].id;
        // toggle button visibility
        $('#addtodo').hide();
        $('#savetodo').show();
    }
    // save changes to FB
    function dosavetodo() {
        var newtodo = {
            todo: $("#todotext").val(),
            iscompleted: $("#todocompleted").val()
        }
        masterXhr("PUT", urlMaker(currId), newtodo, fetch, errorCallback)
        // toggle button visibility
        $('#addtodo').show();
        $('#savetodo').hide();
        $('#todotext').val("");
        $('#todocompleted').val("");
    }

    function init() {
        console.log("init");
        var myTimer = setInterval(fetch, 1000);
    }

    init();

    //displayTweets = function () {

    //  $("#ToDoList").empty();
    //  todo.reverse();
    //  };
    // Expose methods & vars to public
    return {
        doaddtodo: doaddtodo,
        dosavetodo: dosavetodo,
        dodeletetodo: dodeletetodo,
        doupdatetodo: doupdatetodo
    }


})();
