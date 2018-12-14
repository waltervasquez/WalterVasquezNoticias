var app = angular.module('app', []);

app.constant('API_SERVER', {
    API_DEVELOPMENT: 'http://localhost:22750/api/'
});

app.factory('HttpPetitions', ['$q', '$http', 'API_SERVER', function ($q, $http, API_SERVER) {
    function petitionLoadInitial() {        
        var defer = $q.defer();
        var url = API_SERVER.API_DEVELOPMENT + 'getListNews';
        $http.get(url).
          then(function (response) { 
              defer.resolve(response.data);
          });
        return defer.promise;
    }

    return {
        petitionLoadInitial: function () {
            return petitionLoadInitial();
        }
    };

}]);


app.controller('ControllerNews', ['$scope', '$http', 'HttpPetitions', function ($scope, $http, HttpPetitions) {
    
    HttpPetitions.petitionLoadInitial().then(function (data) {
        $scope.dataNews = data;
    });

}]);