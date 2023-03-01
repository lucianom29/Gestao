﻿using DAL;
using Models;
using System.Reflection.Metadata.Ecma335;

namespace BLL
{
    public class UsuarioBLL
    {


        public void Inserir(Usuario _usuario)
        {
            if (_usuario.NomeUsuario.Length <= 3)
                throw new Exception("O nome de ususrio deve ter mais de tres caracteres.");

            if (_usuario.NomeUsuario.Contains(" "))
                throw new Exception("O nome de nao pode ter espaço");

            if (_usuario.Senha.Contains("1234567"))
                throw new Exception("Nao e permitido um numero sequencial.");

            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                throw new Exception("A senha deve ter entre 7 e 11 caracteres.");

            // TODO: Validar se ja existe um usuario com este nome .

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);

        }
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            if (string.IsNullOrEmpty(_nomeUsuario))
                throw new Exception("Infome o nome do usuario.");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorNomeUsuario(_nomeUsuario);
        }
        public List<Usuario> BuscarTodos()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarTodos();
        }
        public void Alterar(Usuario _usuario)
        {

        }
        private static void ValidarDados(Usuario _usuario)
        {
            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 50)
                throw new Exception("O nome de usuario deve ter mais de tres caracteres.");

            if (_usuario.NomeUsuario.Contains(" "))
                     throw new Exception("O nome de usuario nao pode conter espaço");

            if (_usuario.Senha.Contains("123456"))
                throw new Exception("Nao e permitido um numero sequencial.");

            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                throw new Exception("A senha deve ter entre 7 e 11 caracteres.");

        }
        public void Excluir (int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
        }



    }
}




