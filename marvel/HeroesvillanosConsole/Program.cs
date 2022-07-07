using Heroesvillanos;

var repository = new Repository();

repository.LoadFile(@"C:\Users\1\Desktop\marvel_dc_characters.csv");
Console.WriteLine("Se cargo el archivo");
Console.WriteLine("Name    --    Identity  --- Alignment");
foreach (var heroevillano in repository.GetAll().Take(10))
{
    Console.WriteLine($"{heroevillano.Name}    --    {heroevillano.Identity}  ---    {heroevillano.Alignment}");
}
 

 IFileWriter writer = new FileWriterJson();
 writer.Write(repository.GetAll().Take(50).ToList(), "heroesvillanos.json");

Console.Write("Archivo modificado");