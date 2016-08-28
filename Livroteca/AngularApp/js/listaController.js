(function (app) {

    var listaController = function ($scope, $http) {

        $http.get("/api/livro")
              .success(function (data) {
                  $scope.livros = data;
              });
    };

    app.controller("listaController", listaController)

}(angular.module("livroteca", [])))