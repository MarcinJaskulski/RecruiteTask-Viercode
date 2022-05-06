# Introduction

You are implementing a library to manage weather forecasts. The application has already three screens:
- Statistics,
- Weather Forecast,
- Current Weather.

In addition, the library contains a class with a functionality that allows to communicate with API and to pass data from it to the appropriate screens.


# Problem Statement

A design pattern `Observer` has been used for implementing communication between the object that downloaded the API data and the screens. The `Observer` pattern is one of the most popular ways to implement the Hollywood principle (“Don’t call us, we’ll call you.”), according to which one subject notifies all interested subjects about a certain event. 

In this case, the `WeatherData` class stands for a subject that will inform the classes inheriting from `ScreenElements` that the most recent weather data are available. Your task is to supplement the missing implementation of the below methods:
- `WeatherData.Attach` - allows to attach a new screen to Observers, 
- `WeatherData.Detach` - results in detaching a screen from Observers, 
- `WeatherData.Notify` - shows notifying screens in Observers about new data available,
- `Forecast.Update`, `Statistics.Update`, `CurrentWeather.Update` - allow to perform an update of the Observers state.

`Attach`, `Detach` and `Notify` are parts of the `WeatherData` class while `Update` should be added to all methods, i.e. `CurrentWeather`, `Forecast` and `Statistics`. To perform an update, you can use the already implemented methods.

**NOTE:** Please, make sure not to change the task structure/refactor code, as it can break verification process. 

# Hints

In this task, you are implementing the [Observer design pattern](https://en.wikipedia.org/wiki/Observer_pattern).

The Observer pattern uses three actors, i.e. Subject, Observer and Clients. 
Subject is an interface having methods to attach and detach observers to and from a client. In addition, it allows you to make a notification of changes. 
Observer is an interface that declares the Update method which allows to update the state of a notified object.
Clients are the implementation of Observer interface.
