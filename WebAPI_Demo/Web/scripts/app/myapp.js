var app = angular.module("myNoteApp", []);

app.controller("myNoteCtrl", function ($scope, $http) {
    $scope.message = "";
    $scope.left = function () { return 100 - $scope.message.length; };
    $scope.clear = function () { $scope.message = ""; };
    $scope.save = function () { alert("Note Saved"); };

 
    $scope.myclick = function (methcalled) {
       
   
         //var urlString = "http://localhost:53157/api/math/get";
        var urlString = "/api/math/"
         var arg = "value1=" + $scope.Value1 + "&value2=" + $scope.Value2;
         urlString = urlString + methcalled +  "/?" + arg;
      
        $http.get(urlString)
                       .success(function (data) {
                           var myjson = JSON.parse(data);
                           $scope.APIResult = JSON.parse(myjson);

                       })
         .error(function (ex) {
             
             $scope.APIResult = "Error : " + ex.message;

         })



    };

}); // eof app.controller

   

  