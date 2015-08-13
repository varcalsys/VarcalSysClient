app.controller("clienteController", function ($scope, $http) {

    $scope.cliente = {};
    
    $http.post("/Cliente/Registrar").success(function (data) {


        
    }).error(function(data) {

    });


})