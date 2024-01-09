// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization.Formatters;
using Robots;
using Robots2;

Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");

// Correction du constructeur du Robot
Robot robot = new Robot("R2D2", new Point(0, 0));
Console.WriteLine(robot.Name);
AfficherNomRobot(robot, "ROBOOBO");
Console.WriteLine(robot.Name);
void AfficherNomRobot(Robot robot, string name)
{
    robot.Name = name;
}

var a = 5;
var b = 10;

// Correction de la fonction add en ajoutant le mot clé ref au paramètre a
int add(ref int a, int b)
{
    a = 10;
    return a + b;
}

var result = add(ref a, b);

Console.WriteLine(a);
Console.WriteLine(result);


RobotMobile robotMobile = new RobotMobile("R2D2", new Point(0, 0), 10);
robotMobile.Avancer(10, 10);
Console.WriteLine($"ma vitesse est de {robotMobile.CalculerDuréeDeDéplacement(20, 20)}");
Console.WriteLine(robotMobile.AfficherPosition());
Console.WriteLine(robotMobile.Arrêter());
Console.WriteLine(robot.Démarrer());
robotMobile.Nettoyer();
robotMobile.Déplacer(new Point { X = 30, Y = 30 });

//const int MAX_ROBOTS = 5;

//Robot[] robots = new Robot[MAX_ROBOTS];

//for(int i = 0; i < 3; i++)
//{
//    robots[i] = new Robot($"R2D{i}", (decimal)i);
//}

//decimal vitesseMoyenne = 0;

//for(int i = 0; i < 2; i++)
//{
//    vitesseMoyenne = vitesseMoyenne + robots[i].Vitesse;
//}

//vitesseMoyenne = vitesseMoyenne / 3;

//var VitesseMoyenne = robots.Average(r => r.Vitesse);

//Console.WriteLine($"La vitesse moyenne est de {vitesseMoyenne}");

List<Robot2> robotsList = new List<Robot2>();

// Ajouter au moins 5 robots à la liste
robotsList.Add(new Robot2("RobotA", 2021, 0, 0));
robotsList.Add(new Robot2("RobotB", 2022, 10, 10));
robotsList.Add(new Robot2("RobotC", 2023, 20, 20));
robotsList.Add(new Robot2("RobotD", 2024, 30, 30));
robotsList.Add(new Robot2("RobotE", 2025, 40, 40));

// Afficher les informations des robots dans la console
foreach (var robot2 in robotsList)
{
    Console.WriteLine($"Robot Name: {robot.Name}, Year: {robot2.Year}, Position: ({robot2.X}, {robot2.Y})");
}

// Utiliser LINQ pour récupérer tous les robots dont l'année de construction est supérieure à 2005
var robotsAfter2005 = robotsList.Where(robot => robot.Year > 2005).ToList();

// Utiliser LINQ pour trier les robots par leur année de construction, de la plus ancienne à la plus récente
var sortedRobots = robotsList.OrderBy(robot => robot.Year).ToList();

// Utiliser LINQ pour trouver le robot le plus ancien
var oldestRobot = robotsList.OrderBy(robot => robot.Year).FirstOrDefault();

// Afficher les résultats dans la console
Console.WriteLine("Robots dont l'année de construction est supérieure à 2005:");
foreach (var robot2 in robotsAfter2005)
{
    Console.WriteLine($"Robot Name: {robot2.Name}, Year: {robot2.Year}");
}

Console.WriteLine("\nRobots triés par année de construction (de la plus ancienne à la plus récente):");
foreach (var robot2 in sortedRobots)
{
    Console.WriteLine($"Robot Name: {robot2.Name}, Year: {robot2.Year}");
}

Console.WriteLine($"\nLe robot le plus ancien est : {oldestRobot.Name}, Année : {oldestRobot.Year}");
