
Mock<IArticulosRepository> articuloRepo = new Mock<IArticulosRepository>();
Mock<IAutorRepository> autorRepo = new Mock<IAutorRepository>();


autorRepo.Setup(a => a.AutorValido(autorId))



autorRepo.Setup(a => a.AutorValido(It.IsAny<int>())).Returns(true);

articuloRepo.Setup(a => a.InsertarArticulo(contenido, titulo, autorId)).Returns(1);

articuloRepo.Setup(a => a.GetArticulo(1)).Returns(new Articulo()
{
    Autor = new Autor()
    {
        AutorId = autorId,
        Nombre = "test"
    },
    Contenido = contenido,
    Fecha = DateTime.UtcNow,
    Id = 1,
    Titulo = titulo
});


Assert.AreEqual(autorId, articulo.Autor.AutorId);

articuloRepo.Verify(a => a.GetArticulo(1));
articuloRepo.Setup(a => a.InsertarArticulo(contenido, titulo, autorId));
autorRepo.Setup(a => a.AutorValido(It.IsAny<int>()));