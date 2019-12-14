<template>
    <div id="app">

        <nav>
            <div class="nav-wrapper blue darken-1">
                <a href="#" class="brand-logo center">Cadastro de Livros</a>
            </div>
        </nav>

        <div class="container">

            <form>

                <label>Nome</label>
                <input type="text" placeholder="Nome">
                <label>Preco</label>
                <input type="number" placeholder="Preco">
                <label>Categoria</label>
                <input type="text" placeholder="Categoria">
                <label>Autor</label>
                <input type="text" placeholder="Autor">

                <button class="waves-effect waves-light btn-small">Salvar<i class="material-icons left">save</i></button>

            </form>

            <table>

                <thead>

                    <tr>
                        <th>NOME</th>
                        <th>PRECO</th>
                        <th>CATEGORIA</th>
                        <th>AUTOR</th>
                        <th>OPCOES</th>
                    </tr>

                </thead>

                <tbody>

                    <tr>

                        <td>Design Patterns</td>
                        <td>54.93</td>
                        <td>Computers</td>
                        <td>Ralph Johnson</td>
                        <td>
                            <button class="waves-effect btn-small blue darken-1"><i class="material-icons">create</i></button>
                            <button class="waves-effect btn-small red darken-1"><i class="material-icons">delete_sweep</i></button>
                        </td>

                    </tr>

                </tbody>

            </table>

        </div>

    </div>
</template>

<script>

export default {

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
