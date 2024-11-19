//Steg 1
string[] leksaker = {"nerfpistol", "lego", "träsvärd", "rubiks kub", "docka"};

//Steg 2
//foreach (string leksak in leksaker){
//    Console.WriteLine(leksak);
//}


//Steg 3
string[] klasskamrater = {"Blåa Elias", "Långa Elias", "Adam", "Wiggo", "Rasmus"};

//Steg 4
int[] siffror = {1, 4, 6, 7, 9};


//Steg 5
for (int i = 0; i < 5; i++){
    Console.WriteLine($"{klasskamrater[i]} ger {leksaker[i]} betyget {siffror[i]}\n");

}


//Steg 6
List<string> cities = new();


while (Console.ReadLine() != "exit"){
    string input = Console.ReadLine();
    cities.Add(input);
}

//Steg 7
foreach (string h in cities){
    Console.WriteLine(h);
}

Console.ReadLine();