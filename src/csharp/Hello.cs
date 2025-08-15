using System;

class Hello {
    static void Main() {
        Console.WriteLine(HelloWorld("Welt"));
    }
    static string HelloWorld(string name) {
        return "Hallo, " + name + "!";
    }
}