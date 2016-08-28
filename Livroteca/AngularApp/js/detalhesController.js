(function (app) {
    var detalhesController = function ($scope, $http, $routeParams) {
        var id = $routeParams.id;
        $http.get("/api/livro/" + id)
        .success(function (data) {
            $scope.livro = data;
        });
    };
    app.controller("detalhesController", detalhesController)
}(angular.module("livroteca")));