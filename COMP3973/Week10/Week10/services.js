var services = angular.module('studentsApp.services', ['ngResource']);

services.factory('StudentsFactory', function ($resource) {
    return $resource('http://w08.leongr.com/api/Students', {}, {
        query: { method: 'GET', isArray: true },
        create: { method: 'POST' }//, headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }
    })
});

services.factory('StudentFactory', function ($resource) {
    return $resource('http://w08.leongr.com/api/Students/:id/', {}, {
        show: { method: 'GET' },
        update: { method: 'PUT', params: { id: '@StudentId' } },
        delete: { method: 'DELETE', params: { id: '@id' } }
    })
});
