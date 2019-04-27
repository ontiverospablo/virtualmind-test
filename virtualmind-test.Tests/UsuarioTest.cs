using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtualMindTest.Controllers;
using VirtualMindTest.Models;

namespace virtualmind_test.Tests
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void GetUsuarios()
        {
            var expected = new List<User>
            {
                {new User() {Id = 1, Nombre = "Pablo", Apellido = "Ontiveros", Email = "pablo.ontiveros@gmail.com"}},
                {new User() {Id = 2, Nombre = "David", Apellido = "Plaza", Email = "davidplaza@mail.com"}},
                {new User() {Id = 3, Nombre = "Maria", Apellido = "Gomez", Email = "gomezm@mail.com"}},
                {new User() {Id = 4, Nombre = "Jose", Apellido = "Perez", Email = "josep@mail.com"}},
            };

            var controller = new UsuariosController();
            var result = controller.Get();

            result.Should()
                .NotBeEmpty()
                .And.HaveCount(4)
                .And.BeEquivalentTo(expected);
        }
    }
}
