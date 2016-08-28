(function (app) {

    var listaController = function ($scope, $http) {

        $http.get("/api/livro")
              .success(function (data) {
                  $scope.livro = data;
              });
    };

    app.controller("listaController", listaController)

}(angular.module("livroteca", [])))