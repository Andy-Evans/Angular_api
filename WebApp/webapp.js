var app = angular.module('MyApp', [])
    app.controller('MyController', function ($scope, $http) {
       $scope.ButtonClick = function () {
            $scope.Message = $scope.Player.Name;
        }

        $http.get('http://localhost:49966/api/player').
            then(function(response) {
                $scope.Message = response.data[0].Name + " " + response.data[0].Age;
            });        
    });
