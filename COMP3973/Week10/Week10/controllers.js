var app = angular.module('studentsApp.controllers', []);

app.controller('ListController', ['$scope', 'StudentsFactory', 'StudentFactory', '$location',
    function ($scope, StudentsFactory, StudentFactory, $location) {

        // callback for ng-click 'editUser':
        $scope.editStudent = function (studentId) {
            $location.path('/edit/' + studentId);
        };

        // callback for ng-click 'deleteUser':
        $scope.deleteStudent = function (studentId) {
            StudentFactory.delete({ id: studentId });
            $scope.students = StudentsFactory.query();
        };

        // callback for ng-click 'createUser':
        $scope.createStudent = function () {
            $location.path('/create');
        };

        $scope.students = StudentsFactory.query();
    }]);

app.controller('EditController', ['$scope', '$routeParams', 'StudentFactory', '$location',
    function ($scope, $routeParams, StudentFactory, $location) {

        // callback for ng-click 'updateUser':
        $scope.updateStudent = function (studentId) {
            StudentFactory.update($scope.student);
            $location.path('/list');
        };

        // callback for ng-click 'cancel':
        $scope.cancel = function () {
            $location.path('/list');
        };

        $scope.student = StudentFactory.show({ id: $routeParams.id });
    }]);

app.controller('CreateController', ['$scope', 'StudentsFactory', '$location',
    function ($scope, StudentsFactory, $location) {

        // callback for ng-click 'createNewUser':
        $scope.createStudent = function () {
            StudentsFactory.create($scope.student);
            $location.path('/list');
        }
    }]);
