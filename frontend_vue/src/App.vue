<template>
    <div>
        <div id="slogan" class="text-center">
            <h1>Cadastro de Livros</h1>
            <p class="text-secondary">Projeto simples capaz de operar um CRUD sobre Livros.</p>
            <p class="text-secondary">Back: Dotnet Core; Front: Vue; Banco: .</p>
        </div>
        <div id="main">
            <div class="container">
                <div class="row">
                    <div class="col-md">
                        <div class="card">
                            <div class="card-body">

                                <div class="input-group flex-nowrap">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="addon-wrapping">Nome do Livro:</span>
                                    </div>
                                    <input type="text" class="form-control" placeholder="Harry Potter" aria-label="Nome" aria-describedby="addon-wrapping">
                                </div>

                                <br />

                                <div class="input-group flex-nowrap">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="addon-wrapping">Preço:</span>
                                    </div>
                                    <input type="text" class="form-control" placeholder="R$20.50" aria-label="preco" aria-describedby="addon-wrapping">
                                </div>

                                <br />

                                <div class="input-group flex-nowrap">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="addon-wrapping">Tipo:</span>
                                    </div>
                                    <input type="text" class="form-control" placeholder="Drama, Ação ..." aria-label="tipo" aria-describedby="addon-wrapping">
                                </div>

                                <br />

                                <div class="input-group flex-nowrap">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="addon-wrapping">Autor:</span>
                                    </div>
                                    <input type="text" class="form-control" placeholder="J. K. Rowling" aria-label="autor" aria-describedby="addon-wrapping">
                                </div>

                                <br />

                                <button type="submit" class="btn btn-primary">Salvar</button>

                            </div>
                        </div>
                    </div>
                    <div class="col-md">
                        <div class="card">
                            <div class="card-body">
                                <table class="table">
                                    <thead class="thead-dark">
                                        <tr>
                                            <th scope="col">#</th>
                                            <th scope="col">Nome do Livro</th>
                                            <th scope="col">Preço</th>
                                            <th scope="col">Tipo</th>
                                            <th scope="col">Autor</th>
                                            <th scope="col">Editar</th>
                                            <th scope="col">Excluir</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <th scope="row">1</th>
                                            <td>Teste</td>
                                            <td>teste</td>
                                            <td>teste</td>
                                            <td>teste</td>
                                            <td>teste</td>
                                            <td>teste</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div id="footer">
            <div class="card text-center">
                <div class="card-header">
                    Teste de Desempenho
                </div>
                <div class="card-body">
                    <h5 class="card-title">Autor</h5>
                    <p class="card-text">Gustavo Henrique Dias Silva</p>
                    <p><a href="#">GitHub</a></p>
                    <p><a href="#">Linkedin</a></p>
                    <p><a href="#">Email</a></p>
                </div>
                <div class="card-footer text-muted">
                    @Corpyright
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    import "bootstrap/dist/css/bootstrap.css"
    import "font-awesome/css/font-awesome.css"

export default {
  name: 'app',
}
</script>

<style>
#slogan{
    margin-top:30px;
    margin-bottom:30px;
}
#main{
    background-color:#F1F1F1;
    padding-top:30px;
    padding-bottom:30px;
}
#footer{
    position:absolute;
    bottom:0%;
    width:100%;
}
</style>
