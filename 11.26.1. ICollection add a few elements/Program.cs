﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

//	11.26.1.	ICollection: add a few elements to the collection

public class MainClass
{

    public static void Main()
    {
        ICollection<int> myCollection = new Collection<int>();

        myCollection.Add(105);
        myCollection.Add(232);
        myCollection.Add(350);
    }
}