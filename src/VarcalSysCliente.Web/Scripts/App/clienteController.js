app.controller("clienteController", function($scope, $http) {
   

    $scope.estados = [
        { uf: 'AC', id: 1 }, { uf: 'AL', id: 2 }, { uf: 'AP', id: 3 }, { uf: 'AM', id: 4 }, { uf: 'BA', id: 5 },
        { uf: 'CE', id: 6 }, { uf: 'DF', id: 7 }, { uf: 'ES', id: 8 }, { uf: 'GO', id: 9 }, { uf: 'MA', id: 10 },
        { uf: 'MT', id: 11 }, { uf: 'MS', id: 12 }, { uf: 'MG', id: 13 }, { uf: 'PR', id: 14 }, { uf: 'PB', id: 15 },
        { uf: 'PA', id: 16 }, { uf: 'PE', id: 17 }, { uf: 'PI', id: 18 }, { uf: 'RJ', id: 19 }, { uf: 'RN', id: 20 },
        { uf: 'RS', id: 21 }, { uf: 'RO', id: 22 }, { uf: 'RR', id: 23 }, { uf: 'SC', id: 24 }, { uf: 'SE', id: 25 },
        { uf: 'SP', id: 26 }, { uf: 'TO', id: 27 }
    ];


    $scope.pessoaTipoList = [{ Id: 1, Descricao: "Pessoa Física" }, { Id: 2, Descricao: "Pessoa Jurídica" }];
    
    
    $http.get('/PlanoHost/GetJson').success(function (data) {

        if (data.length > 0) {
            console.log(data);
            $scope.planosHost = data;
        } else {
            alert('Nenhum plano cadastrado');
        }

    }).error(function (data) {
        alert("Não foi possível carregar os planos");
    });


});