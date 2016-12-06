'use strict';

registrationModule.factory('accountRepository',
    function($http,$q) {
        return{
            save: function (student) {
                var deferred = $q.defer();
                $http.post('/Account/Save', student).success(function () { deferred.resolve(); });
                return deferred.promise;
            }
        };
    });