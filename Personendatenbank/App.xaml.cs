﻿namespace Personendatenbank
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Pages.Pg_AddPerson();

            //MainPage = new Lab05_Layoutübungen.Pg_AbsoluteLayoutLab();
        }
    }
}