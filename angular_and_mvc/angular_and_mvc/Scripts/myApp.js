//Define the angular App
var myApp = angular.module("myApp", []);

//Controler - Home
myApp.controller("HomeController", function ($scope) {
    //
    $scope.greeting = "hello: ";

    // Scoped objects for the index view, this is where they go
    $scope.wName = "";
    $scope.wCountry = "";
    $scope.wType = "";
    $scope.wYear = "";
    $scope.wColor = "";

    //array to contain all of the data
    $scope.myContacts = [];  //model
    //hold current index(edit & delete)
    $scope.myIndex = 0;
    //set userEditing to false so that the save button does not appear until edit is pressed
    $scope.userEdit = false;
    //user clicks-ADD
    $scope.getUserDetails = function () {
        
        //create - user click ADD
        var objToAdd = {
            wName: $scope.wName,
            wCountry: $scope.wCountry,
            wType: $scope.wType,
            wYear: $scope.wYear,
            wColor: $scope.wColor
        };
        $scope.myContacts.push(objToAdd);
        //console.log($scope.Name, $scope.Country, $scope.Type, $scope.Year, $scope.Color, $scope.myContacts);
    }
    //------------------------------
    //Update - User clicked edit, populate input boxes
    //-----------------------------------------------------
    $scope.userEdit = function (arrIndex) {
        $scope.myIndex = arrIndex; //captures the current index
        $scope.editMode = true;//activate the edit mode button
        //console.log("test edit", idIndex, $scope.myContacts[itemToPost]);
        //coordinate population of fields...
        $scope.wName = $scope.myContacts[arrIndex].name;
        $scope.wCountry = $scope.myContacts[arrIndex].country;
        $scope.wType = $scope.myContacts[arrIndex].type;
        $scope.wYear = $scope.myContacts[arrIndex].year;
        $scope.wColor= $scope.myContacts[arrIndex].color;
        
    }
    $scope.saveUserDetails = function () {
        var objToAdd = {
            name: $scope.wName,
            country: $scope.wCountry,
            type: $scope.wType,
            year: $scope.wYear,
            color: $scope.wColor
        }

        $scope.myContacts[$scope.myIndex] = objToAdd;
        $scope.editMode = false;
        $scope.clearFields();

        $scope.clearFields = function() {
            $scope.wName = "";
            $scope.wCountry = "";
            $scope.wType = "";
            $scope.wYear = "";
            $scope.wColor = "";

        };
        //--------------------------------
        //        DELETE
        //--------------------------------------
        //wait for user to edit the fields, then save changes on click
        $scope.userDelete = function (x) {
            $scope.myContacts.splice(x, 1);
        }
    }
});