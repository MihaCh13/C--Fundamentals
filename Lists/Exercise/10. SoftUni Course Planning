using System.Collections.Generic;

List<string> myList = Console.ReadLine()
    .Split(", ")
    .ToList();

string command = "";
while ((command = Console.ReadLine()) != "course start")
{
    string[] commandArray = command.Split(":").ToArray();

    if (commandArray[0] == "Add")
    {
        addMethod(myList, commandArray);
    }
    else if (commandArray[0] == "Insert")
    {
        insertMethod(myList, commandArray);
    }
    else if (commandArray[0] == "Remove")
    {
        RemoveMethod(myList, commandArray);
    }
    else if (commandArray[0] == "Swap")
    {
        SwapMethod(myList, commandArray);
    }
    else if (commandArray[0] == "Exercise")
    {
        ExersiceMethod(myList, commandArray);
    }
}

for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine($"{i+1}.{myList[i]}");
}

void addMethod(List<string> list, string[] strings)
{
    if (!list.Contains(strings[1]))
    {
        list.Add(strings[1]);
    }
}
void insertMethod(List<string> list, string[] command)
{
    string lessonTitle = command[1];
    int index = int.Parse(command[2]);

    if (index < 0 || index >= list.Count)
    {
        return;
    }
    else if (!list.Contains(lessonTitle))
    {
        list.Insert(index, lessonTitle);
    }
}
void RemoveMethod(List<string> list, string[] strings)
{
    bool foundExersice = false;
    int indexOfRemoved = list.IndexOf(strings[1]);
    string ExerciseElement = "";
    if (list.Count - 1 != indexOfRemoved)
    {
         ExerciseElement = list.ElementAt(1 + indexOfRemoved);
    }

    if (ExerciseElement == ($"{strings[1]}-Exercise"))
    {
        foundExersice = true;
    }
    if (list.Contains(strings[1]))
    {
        list.Remove(strings[1]);
        if (foundExersice)
        {
            list.Remove(ExerciseElement);
        }   
    }
}

void ExersiceMethod(List<string> myList1, string[] commandArray1)
{
    if (myList1.Contains(commandArray1[1]) && !myList1.Contains(commandArray1[1] + "-Exercise"))
    {
        int indexOfLecture = myList1.IndexOf(commandArray1[1]);
        myList1.Insert(indexOfLecture + 1, ($"{commandArray1[1]}-Exercise"));
        
    }
    else if(!myList1.Contains(commandArray1[1]))
    {
        myList1.Add(commandArray1[1]);
        myList1.Add((commandArray1[1]+ "-Exercise"));
    }
}

void SwapMethod(List<string> list1, string[] command)
{
    string lessonTitle1 = command[1];
    string lessonTitle2 = command[2];
    int index1 = list1.IndexOf(lessonTitle1);
    int index2 = list1.IndexOf(lessonTitle2);
    if (list1.Contains(lessonTitle1) && list1.Contains(lessonTitle2))
    {
        string tempstring = lessonTitle1;
        list1[index1] = lessonTitle2;
        list1[index2] = tempstring;

    }

    if (list1.Contains(lessonTitle1 + "-Exercise") )
    {
        index1 = list1.IndexOf(lessonTitle1);
        list1.Remove(lessonTitle1 + "-Exercise");
        list1.Insert(index1 + 1, lessonTitle1 + "-Exercise");
    }
    else if (list1.Contains(lessonTitle2 + "-Exercise") )
    {
        index2 = list1.IndexOf(lessonTitle2);
        list1.Remove(lessonTitle2 + "-Exercise");
        list1.Insert(index2 + 1, lessonTitle2 + "-Exercise");
    }
}
