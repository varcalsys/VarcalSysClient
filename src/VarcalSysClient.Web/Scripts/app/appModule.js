
var app = angular.module("app", ["$scope","ngRoute"]);

app.config(function($routeProvider) {
    $routeProvider
        .when("/Cliente/Registrar", {
            templateUrl: "Registrar.cshtml",
            controller: "clienteController"
        }).when("/Cliente", {
            templateUrl: "Index.cshtml",
            controller: "clienteController"
        }).otherwise({
            redirectTo: "/Home"
        });
});