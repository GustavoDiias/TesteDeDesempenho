<template>
    <div id="app">

        <nav>
            <div class="nav-wrapper blue darken-1">
                <a href="#" class="brand-logo center">Cadastro de Livros</a>
            </div>
        </nav>

        <div class="container">
            <form @submit.prevent="salvar">
                <label>Nome</label>
                <input type="text" placeholder="Nome" v-model="livro.nome">
                <label>Preco</label>
                <input type="number" placeholder="Preco" v-model="livro.preco">
                <label>Categoria</label>
                <input type="text" placeholder="Categoria" v-model="livro.categoria">
                <label>Autor</label>
                <input type="text" placeholder="Autor" v-model="livro.autor">

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

                    <tr v-for="livro of livros" :key="livro.id">

                        <td>{{livro.nome}}</td>
                        <td>{{livro.preco}}</td>
                        <td>{{livro.categoria}}</td>
                        <td>{{livro.autor}}</td>
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

import Livro from './services/livros'

export default {

        data() {
        return {
            livro: {
                nome: '',
                preco: '',
                categoria: '',
                autor:''
            },
                livros:[]
            }
        },

        mounted() {

            this.listar()

        },

        methods: {

            listar() {

                Livro.listar().then(resposta => {
                this.livros = resposta.data
                })

            },

            salvar() {
                Livro.salvar(this.livro).then(resposta => {
                    this.livro = {}
                    resposta.alert('Salvo com Sucesso!')
                    this.salvar
                })
            }
        }
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
