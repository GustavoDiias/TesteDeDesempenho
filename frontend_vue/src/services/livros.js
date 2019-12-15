import { http } from './config'

export default {

    listar: () => {
        return http.get('livros')
    },

    salvar: (livro) => {
        return http.post('livro',livro)
    }
}