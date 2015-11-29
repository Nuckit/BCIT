angular.module('studentsApp', ['studentsApp.services', 'studentsApp.controllers']).
    config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/list', { templateUrl: 'list.html', controller: 'ListController' });
        $routeProvider.when('/edit/:id', { templateUrl: 'edit.html', controller: 'EditController' });
        $routeProvider.when('/create', { templateUrl: 'create.html', controller: 'CreateController' });
        $routeProvider.otherwise({ redirectTo: '/list' });
    }]);
