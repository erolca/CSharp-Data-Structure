﻿using System;
using System.IO;
using System.Collections;

using System.Runtime.Serialization.Formatters.Binary;

//11.25.2.	Deserialize an ArrayList object from a binary file

class MainClass
{
    public static void Main()
    {
        ArrayList people = new ArrayList();
        people.Add("G");
        people.Add("L");
        people.Add("A");


        BinarySerialize(people);

        ArrayList binaryPeople = BinaryDeserialize();
        Console.WriteLine("Binary people:");
        foreach (string s in binaryPeople)
        {
            Console.WriteLine("\t" + s);
        }
    }

    private static void BinarySerialize(ArrayList list)
    {
        using (FileStream str = File.Create("people.bin"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(str, list);
        }
    }


    private static ArrayList BinaryDeserialize()
    {
        ArrayList people = null;

        using (FileStream str = File.OpenRead("people.bin"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            people = (ArrayList)bf.Deserialize(str);
        }
        return people;
    }

}
//Binary people:
//        G
//        L
//        A