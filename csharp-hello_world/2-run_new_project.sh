#!/usr/bin/env bash
# this will initialize thyen build and start a new csharp project
dotnet new console -n 1-new_project
cd 1-new_project
dotnet build
dotnet run
