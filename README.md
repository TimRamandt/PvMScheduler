# PvM Scheduler
This is aimed for persons who regularly host PvM sessions. It is sometimes hard to keep track on a daily basis with lists. Mistakes are bound to happen *(personal experience)*. This bot will keep track of these PvMing events and roles and will notify the attendees.

This software is free to re-use. You get the source code, but you have to host/set up your own discord bot.

## Discord
Documentation on how to set-up your (private) Discord bot can be found [here](https://discordapp.com/developers/docs/intro). This [turtorial](https://github.com/reactiflux/discord-irc/wiki/Creating-a-discord-bot-&-getting-a-token) might also help.

## Running the bot
This program is writen in C# with .NET Core. To run .NET Core, you will need .NET Core SDK, which can be found [here](https://github.com/dotnet/core/blob/master/release-notes/download-archives/2.1.2-download.md)

### Creating/altering the database
The bot uses [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/get-started/install/) to interact with the database. All logic of the data can be found in the data project.

The database is created and model alterations are based on migrations. A detailed explaination about migrations for .NET Core can be found [here](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/) _(different than classic .NET)_
