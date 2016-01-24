// Created by Seunghyun Yoo
// 11.1.2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thePlayground
{
    class menuDisplay
    {
        // Main menu display
        public static void launchMenu()
        {
            global.conClear();
            global.makeLine();
            Console.WriteLine(
                "The Playground");
            global.makeLine();
            Console.WriteLine(
                "User Authentication");
            global.makeLine();
            Console.WriteLine(
                "1. Login\n" +
                "2. Create an Account\n" + 
                "3. Quit");
            global.makeLine();
            global.dispMessage(global.msgType);
            global.makeLine();
            Console.Write(
                "->: ");
        }

        // Login Menu Display (username)
        public static void loginMenu()
        {
            global.conClear();
            global.makeLine();
            Console.WriteLine(
                "Login");
            global.makeLine();
            Console.WriteLine(
                "Enter your username");
            global.makeLine();
            global.dispMessage(global.msgType);
            global.makeLine();
            Console.Write(
                "->: ");
        }
        // Login Menu Display (password)
        public static void loginMenuPswd()
        {
            global.conClear();
            global.makeLine();
            Console.WriteLine(
                "Login");
            global.makeLine();
            Console.WriteLine(
                "Enter your password");
            global.makeLine();
            global.dispMessage(global.msgType);
            global.makeLine();
            Console.Write(
                "->: ");
        }

        // Create (username) screen
        public static void createMenu()
        {
            global.conClear();
            global.makeLine();
            Console.WriteLine(
                "Create User");
            global.makeLine();
            Console.WriteLine(
                "Enter your desired Username");
            global.makeLine();
            global.dispMessage(global.msgType);
            global.makeLine();
            Console.Write(
                "->: ");
        }
        // Create (password) screen
        public static void createMenuPswd()
        {
            global.conClear();
            global.makeLine();
            Console.WriteLine(
                "Login");
            global.makeLine();
            Console.WriteLine(
                "Enter your password");
            global.makeLine();
            global.dispMessage(global.msgType);
            global.makeLine();
            Console.Write(
                "->: ");
        }

        // This menu can be open to change (Obv. add more stuff in)
        public static void loggedInMenu()
        {
            global.conClear();
            global.makeLine();
            Console.WriteLine(
                "Main Menu");
            global.makeLine();
            Console.WriteLine(
                "Make a Selection.");
            global.makeLine();
            Console.WriteLine(
            "1. Calendar\n" +
            "2. Notes\n" +
            "3. Logout");
            global.makeLine();
            global.dispMessage(global.msgType);
            global.makeLine();
            Console.Write(
                "->: ");
        }
    }
}
