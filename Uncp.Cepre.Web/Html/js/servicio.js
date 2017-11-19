var Url = "http://localhost:52493/";

function httpPostFactory ($q,$http) {
    return function (url, datos) {
         return $http({
            url: url,
            method: 'POST',
            headers : {'Content-Type' : 'application/json'},
            data: datos
        })
        .success(function (data, status, headers, config) {
            if (typeof data === 'object') {
                $("#divLoading").hide();
                return data;
            } else {
                // invalid response
                $("#divLoading").hide();
                return $q.reject(data);
            }
        })
        .error(function (data, status) {
            // Captura HTTP error
            $("#divLoading").hide();
        })
        .finally(function () {
            // ejecuta independientemente de success y error  
            $("#divLoading").hide();
        })
        .catch(function (error) {
            console.log('Error execution');
            $("#divLoading").hide();
            return $q.reject(error);
            //captura y ecpone  exceptions de success/error/finally functions
        });
    }
}


function EstudianteFactory(httpPostFactory) {
   
    return ({
        BuscarPorDni: function (dni) {
            var url = Url + "Estudiante/BuscarPorDni/" + dni;
            
            return httpPostFactory(url, {})
        },
        GuardarEstudiante: function (estudiante) {
            var url = Url + "Estudiante/Guardar/";
            return httpPostFactory(url, estudiante)
        }
    });

}

	


// function SumaCtrl($scope){
// 	//this.Resultado= 589;
// 	$scope.Resultado= 583339;
// };
// angular
// .module('inspinia')
// .controller('SumaCtrl', ['$scope',SumaCtrl]);

function ListaService()
{ var fac={};
		fac.Resultado = function(){
			return 15847;
		}
	return fac;
};
angular
    .module('inspinia')
	.factory('ListaService', ListaService)
	.factory('httpPostFactory', ['$q','$http',httpPostFactory])
    .factory('EstudianteFactory', ['httpPostFactory', EstudianteFactory])
	;