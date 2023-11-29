// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var campusModel = new CampusModel();
var nsuCampus = new NsuCampusFactory(campusModel);

var campus = nsuCampus.Create();

Console.WriteLine(campus);

Console.ReadLine();