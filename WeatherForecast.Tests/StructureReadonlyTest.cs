
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace WeatherForecast.Tests
{
    /// <summary>
    /// !!! WARNING 
    /// !!! Project structure test.
    /// !!! DON'T CHANGE IT! 
    /// !!! Changes may cause the solution to be rejected.
    /// </summary>
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        [Test]
        public void StructureTest()
        {
            Assembly assembly;
            Type type;
            Type methodReturnType;
            MethodInfo method;
            ParameterInfo parameter;
            int parametersCount;
            List<string> constructorParameterNameTypeDictionary;
            ConstructorInfo constructor;
            FieldInfo field;
            Type fieldReturnType;
            assembly = Assembly.Load(Decode("V2VhdGhlckZvcmVjYXN0LCBWZXJzaW9uPTEuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49bnVsbA==") /*"WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("Q3VycmVudFdlYXRoZXI=") /*"CurrentWeather"*/ );
            Assert.IsNotNull(type, "Missing assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather");
            Assert.IsTrue(type.IsClass, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather is not class");
            Assert.IsTrue(type.IsPublic, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather is not public class");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("VXBkYXRl") /*"Update"*/ ); Assert.IsNotNull(method, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather.Update() does not exists");
            Assert.IsTrue(method.IsPublic, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather.Update() is not public");
            Assert.IsTrue(method.IsVirtual, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather.Update() is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather.Update() return type has changed");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather() does not exists");
            constructorParameterNameTypeDictionary = new List<string>();
            constructorParameterNameTypeDictionary.Add("WeatherForecast.Interfaces.Subject");
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather(Subject subject) does not exists");
            parametersCount = constructor.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather(Subject subject)  parameters count has changed");
            parameter = constructor.GetParameters().FirstOrDefault(x => x.Name == Decode("c3ViamVjdA==") /*"subject"*/  && x.ParameterType.FullName == "WeatherForecast.Interfaces.Subject");
            Assert.IsNotNull(parameter, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather(Subject subject) parameter subject does not exists or does not have type WeatherForecast.Interfaces.Subject");
            field = type.GetFields().FirstOrDefault(x => x.Name == Decode("Q3VycmVudFdlYXRoZXJJbmZvcm1hdGlvbg==") /*"CurrentWeatherInformation"*/ );
            Assert.IsNotNull(field, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather.String CurrentWeatherInformation does not exists");
            Assert.IsTrue(field.IsPublic, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather.String CurrentWeatherInformation is not public");
            fieldReturnType = field.FieldType;
            Assert.AreEqual("System.String", fieldReturnType.FullName, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather.String CurrentWeatherInformation  type has changed");
            field = type.GetFields().FirstOrDefault(x => x.Name == Decode("U3ViamVjdA==") /*"Subject"*/ );
            Assert.IsNotNull(field, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather.Subject Subject does not exists");
            Assert.IsTrue(field.IsPublic, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather.Subject Subject is not public");
            fieldReturnType = field.FieldType;
            Assert.AreEqual("WeatherForecast.Interfaces.Subject", fieldReturnType.FullName, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.CurrentWeather.Subject Subject  type has changed");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("Rm9yZWNhc3Q=") /*"Forecast"*/ );
            Assert.IsNotNull(type, "Missing assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast");
            Assert.IsTrue(type.IsClass, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast is not class");
            Assert.IsTrue(type.IsPublic, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast is not public class");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("VXBkYXRl") /*"Update"*/ ); Assert.IsNotNull(method, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast.Update() does not exists");
            Assert.IsTrue(method.IsPublic, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast.Update() is not public");
            Assert.IsTrue(method.IsVirtual, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast.Update() is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast.Update() return type has changed");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast() does not exists");
            constructorParameterNameTypeDictionary = new List<string>();
            constructorParameterNameTypeDictionary.Add("WeatherForecast.Interfaces.Subject");
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast(Subject subject) does not exists");
            parametersCount = constructor.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast(Subject subject)  parameters count has changed");
            parameter = constructor.GetParameters().FirstOrDefault(x => x.Name == Decode("c3ViamVjdA==") /*"subject"*/  && x.ParameterType.FullName == "WeatherForecast.Interfaces.Subject");
            Assert.IsNotNull(parameter, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast(Subject subject) parameter subject does not exists or does not have type WeatherForecast.Interfaces.Subject");
            field = type.GetFields().FirstOrDefault(x => x.Name == Decode("Rm9yZWNhc3RGb3JOZXh0RGF5cw==") /*"ForecastForNextDays"*/ );
            Assert.IsNotNull(field, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast.String ForecastForNextDays does not exists");
            Assert.IsTrue(field.IsPublic, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast.String ForecastForNextDays is not public");
            fieldReturnType = field.FieldType;
            Assert.AreEqual("System.String", fieldReturnType.FullName, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast.String ForecastForNextDays  type has changed");
            field = type.GetFields().FirstOrDefault(x => x.Name == Decode("U3ViamVjdA==") /*"Subject"*/ );
            Assert.IsNotNull(field, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast.Subject Subject does not exists");
            Assert.IsTrue(field.IsPublic, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast.Subject Subject is not public");
            fieldReturnType = field.FieldType;
            Assert.AreEqual("WeatherForecast.Interfaces.Subject", fieldReturnType.FullName, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Forecast.Subject Subject  type has changed");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("U3RhdGlzdGljcw==") /*"Statistics"*/ );
            Assert.IsNotNull(type, "Missing assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics");
            Assert.IsTrue(type.IsClass, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics is not class");
            Assert.IsTrue(type.IsPublic, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics is not public class");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("VXBkYXRl") /*"Update"*/ ); Assert.IsNotNull(method, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics.Update() does not exists");
            Assert.IsTrue(method.IsPublic, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics.Update() is not public");
            Assert.IsTrue(method.IsVirtual, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics.Update() is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics.Update() return type has changed");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics() does not exists");
            constructorParameterNameTypeDictionary = new List<string>();
            constructorParameterNameTypeDictionary.Add("WeatherForecast.Interfaces.Subject");
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics(Subject subject) does not exists");
            parametersCount = constructor.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics(Subject subject)  parameters count has changed");
            parameter = constructor.GetParameters().FirstOrDefault(x => x.Name == Decode("c3ViamVjdA==") /*"subject"*/  && x.ParameterType.FullName == "WeatherForecast.Interfaces.Subject");
            Assert.IsNotNull(parameter, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics(Subject subject) parameter subject does not exists or does not have type WeatherForecast.Interfaces.Subject");
            field = type.GetFields().FirstOrDefault(x => x.Name == Decode("VGVtcGVyYXR1cmVTdGF0aXN0aWNz") /*"TemperatureStatistics"*/ );
            Assert.IsNotNull(field, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics.Decimal TemperatureStatistics does not exists");
            Assert.IsTrue(field.IsPublic, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics.Decimal TemperatureStatistics is not public");
            fieldReturnType = field.FieldType;
            Assert.AreEqual("System.Decimal", fieldReturnType.FullName, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics.Decimal TemperatureStatistics  type has changed");
            field = type.GetFields().FirstOrDefault(x => x.Name == Decode("U3ViamVjdA==") /*"Subject"*/ );
            Assert.IsNotNull(field, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics.Subject Subject does not exists");
            Assert.IsTrue(field.IsPublic, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics.Subject Subject is not public");
            fieldReturnType = field.FieldType;
            Assert.AreEqual("WeatherForecast.Interfaces.Subject", fieldReturnType.FullName, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Statistics.Subject Subject  type has changed");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("V2VhdGhlckRhdGE=") /*"WeatherData"*/ );
            Assert.IsNotNull(type, "Missing assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData");
            Assert.IsTrue(type.IsClass, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData is not class");
            Assert.IsTrue(type.IsPublic, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData is not public class");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("QXR0YWNo") /*"Attach"*/ ); Assert.IsNotNull(method, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.Attach(Observer o) does not exists");
            Assert.IsTrue(method.IsPublic, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.Attach(Observer o) is not public");
            Assert.IsTrue(method.IsVirtual, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.Attach(Observer o) is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.Attach(Observer o) return type has changed");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.Attach(Observer o) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("bw==") /*"o"*/  && x.ParameterType.FullName == "WeatherForecast.Interfaces.Observer");
            Assert.IsNotNull(parameter, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.Attach(Observer o) parameter o does not exists or does not have type WeatherForecast.Interfaces.Observer");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("RGV0YWNo") /*"Detach"*/ ); Assert.IsNotNull(method, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.Detach(Observer o) does not exists");
            Assert.IsTrue(method.IsPublic, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.Detach(Observer o) is not public");
            Assert.IsTrue(method.IsVirtual, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.Detach(Observer o) is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.Detach(Observer o) return type has changed");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.Detach(Observer o) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("bw==") /*"o"*/  && x.ParameterType.FullName == "WeatherForecast.Interfaces.Observer");
            Assert.IsNotNull(parameter, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.Detach(Observer o) parameter o does not exists or does not have type WeatherForecast.Interfaces.Observer");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("Tm90aWZ5") /*"Notify"*/ ); Assert.IsNotNull(method, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.Notify() does not exists");
            Assert.IsTrue(method.IsPublic, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.Notify() is not public");
            Assert.IsTrue(method.IsVirtual, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.Notify() is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.Notify() return type has changed");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("U2V0RGF0YQ==") /*"SetData"*/ ); Assert.IsNotNull(method, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.SetData(TemperatureInformation ti) does not exists");
            Assert.IsTrue(method.IsPublic, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.SetData(TemperatureInformation ti) is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.SetData(TemperatureInformation ti) return type has changed");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.SetData(TemperatureInformation ti) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("dGk=") /*"ti"*/  && x.ParameterType.FullName == "WeatherForecast.classes.TemperatureInformation");
            Assert.IsNotNull(parameter, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.SetData(TemperatureInformation ti) parameter ti does not exists or does not have type WeatherForecast.classes.TemperatureInformation");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData() does not exists");
            field = type.GetFields().FirstOrDefault(x => x.Name == Decode("T2JzZXJ2ZXJz") /*"Observers"*/ );
            Assert.IsNotNull(field, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.IList`1 Observers does not exists");
            Assert.IsTrue(field.IsPublic, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.IList`1 Observers is not public");
            fieldReturnType = field.FieldType;
            Assert.AreEqual("System.Collections.Generic.IList`1[[WeatherForecast.Interfaces.Observer, WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]", fieldReturnType.FullName, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.IList`1 Observers  type has changed");
            field = type.GetFields().FirstOrDefault(x => x.Name == Decode("VGVtcGVyYXR1cmVJbmZvcm1hdGlvbg==") /*"TemperatureInformation"*/ );
            Assert.IsNotNull(field, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.TemperatureInformation TemperatureInformation does not exists");
            Assert.IsTrue(field.IsPublic, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.TemperatureInformation TemperatureInformation is not public");
            fieldReturnType = field.FieldType;
            Assert.AreEqual("WeatherForecast.classes.TemperatureInformation", fieldReturnType.FullName, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.WeatherData.TemperatureInformation TemperatureInformation  type has changed");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("T2JzZXJ2ZXI=") /*"Observer"*/ );
            Assert.IsNotNull(type, "Missing assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Observer");
            Assert.IsTrue(type.IsAbstract, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Observer is not abstract class");
            Assert.IsTrue(type.IsInterface, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Observer is not interface");
            Assert.IsTrue(type.IsPublic, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Observer is not public class");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("VXBkYXRl") /*"Update"*/ ); Assert.IsNotNull(method, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Observer.Update() does not exists");
            Assert.IsTrue(method.IsPublic, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Observer.Update() is not public");
            Assert.IsTrue(method.IsAbstract, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Observer.Update() is not abstract");
            Assert.IsTrue(method.IsVirtual, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Observer.Update() is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Observer.Update() return type has changed");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("U3ViamVjdA==") /*"Subject"*/ );
            Assert.IsNotNull(type, "Missing assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject");
            Assert.IsTrue(type.IsAbstract, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject is not abstract class");
            Assert.IsTrue(type.IsInterface, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject is not interface");
            Assert.IsTrue(type.IsPublic, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject is not public class");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("QXR0YWNo") /*"Attach"*/ ); Assert.IsNotNull(method, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Attach(Observer o) does not exists");
            Assert.IsTrue(method.IsPublic, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Attach(Observer o) is not public");
            Assert.IsTrue(method.IsAbstract, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Attach(Observer o) is not abstract");
            Assert.IsTrue(method.IsVirtual, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Attach(Observer o) is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Attach(Observer o) return type has changed");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Attach(Observer o) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("bw==") /*"o"*/  && x.ParameterType.FullName == "WeatherForecast.Interfaces.Observer");
            Assert.IsNotNull(parameter, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Attach(Observer o) parameter o does not exists or does not have type WeatherForecast.Interfaces.Observer");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("RGV0YWNo") /*"Detach"*/ ); Assert.IsNotNull(method, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Detach(Observer o) does not exists");
            Assert.IsTrue(method.IsPublic, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Detach(Observer o) is not public");
            Assert.IsTrue(method.IsAbstract, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Detach(Observer o) is not abstract");
            Assert.IsTrue(method.IsVirtual, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Detach(Observer o) is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Detach(Observer o) return type has changed");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Detach(Observer o) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("bw==") /*"o"*/  && x.ParameterType.FullName == "WeatherForecast.Interfaces.Observer");
            Assert.IsNotNull(parameter, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Detach(Observer o) parameter o does not exists or does not have type WeatherForecast.Interfaces.Observer");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("Tm90aWZ5") /*"Notify"*/ ); Assert.IsNotNull(method, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Notify() does not exists");
            Assert.IsTrue(method.IsPublic, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Notify() is not public");
            Assert.IsTrue(method.IsAbstract, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Notify() is not abstract");
            Assert.IsTrue(method.IsVirtual, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Notify() is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.Interfaces.Subject.Notify() return type has changed");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("U2NyZWVuRWxlbWVudA==") /*"ScreenElement"*/ );
            Assert.IsNotNull(type, "Missing assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.ScreenElement");
            Assert.IsTrue(type.IsClass, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.ScreenElement is not class");
            Assert.IsTrue(type.IsAbstract, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.ScreenElement is not abstract class");
            Assert.IsTrue(type.IsPublic, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.ScreenElement is not public class");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("VXBkYXRl") /*"Update"*/ ); Assert.IsNotNull(method, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.ScreenElement.Update() does not exists");
            Assert.IsTrue(method.IsPublic, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.ScreenElement.Update() is not public");
            Assert.IsTrue(method.IsAbstract, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.ScreenElement.Update() is not abstract");
            Assert.IsTrue(method.IsVirtual, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.ScreenElement.Update() is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.ScreenElement.Update() return type has changed");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.ScreenElement() does not exists");
            constructorParameterNameTypeDictionary = new List<string>();
            constructorParameterNameTypeDictionary.Add("WeatherForecast.Interfaces.Subject");
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.ScreenElement(Subject subject) does not exists");
            parametersCount = constructor.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.ScreenElement(Subject subject)  parameters count has changed");
            parameter = constructor.GetParameters().FirstOrDefault(x => x.Name == Decode("c3ViamVjdA==") /*"subject"*/  && x.ParameterType.FullName == "WeatherForecast.Interfaces.Subject");
            Assert.IsNotNull(parameter, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.ScreenElement(Subject subject) parameter subject does not exists or does not have type WeatherForecast.Interfaces.Subject");
            field = type.GetFields().FirstOrDefault(x => x.Name == Decode("U3ViamVjdA==") /*"Subject"*/ );
            Assert.IsNotNull(field, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.ScreenElement.Subject Subject does not exists");
            Assert.IsTrue(field.IsPublic, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.ScreenElement.Subject Subject is not public");
            fieldReturnType = field.FieldType;
            Assert.AreEqual("WeatherForecast.Interfaces.Subject", fieldReturnType.FullName, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.ScreenElement.Subject Subject  type has changed");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("VGVtcGVyYXR1cmVJbmZvcm1hdGlvbg==") /*"TemperatureInformation"*/ );
            Assert.IsNotNull(type, "Missing assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.TemperatureInformation");
            Assert.IsTrue(type.IsClass, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.TemperatureInformation is not class");
            Assert.IsTrue(type.IsPublic, "assembly: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.TemperatureInformation is not public class");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.TemperatureInformation() does not exists");
            field = type.GetFields().FirstOrDefault(x => x.Name == Decode("VG9kYXk=") /*"Today"*/ );
            Assert.IsNotNull(field, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.TemperatureInformation.Decimal Today does not exists");
            Assert.IsTrue(field.IsPublic, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.TemperatureInformation.Decimal Today is not public");
            fieldReturnType = field.FieldType;
            Assert.AreEqual("System.Decimal", fieldReturnType.FullName, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.TemperatureInformation.Decimal Today  type has changed");
            field = type.GetFields().FirstOrDefault(x => x.Name == Decode("VG9tb3Jyb3c=") /*"Tomorrow"*/ );
            Assert.IsNotNull(field, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.TemperatureInformation.Decimal Tomorrow does not exists");
            Assert.IsTrue(field.IsPublic, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.TemperatureInformation.Decimal Tomorrow is not public");
            fieldReturnType = field.FieldType;
            Assert.AreEqual("System.Decimal", fieldReturnType.FullName, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.TemperatureInformation.Decimal Tomorrow  type has changed");
            field = type.GetFields().FirstOrDefault(x => x.Name == Decode("VGhlRGF5QWZ0ZXJUb21vcnJvdw==") /*"TheDayAfterTomorrow"*/ );
            Assert.IsNotNull(field, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.TemperatureInformation.Decimal TheDayAfterTomorrow does not exists");
            Assert.IsTrue(field.IsPublic, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.TemperatureInformation.Decimal TheDayAfterTomorrow is not public");
            fieldReturnType = field.FieldType;
            Assert.AreEqual("System.Decimal", fieldReturnType.FullName, "field: WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:WeatherForecast.classes.TemperatureInformation.Decimal TheDayAfterTomorrow  type has changed");
        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        private string Decode(string text)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(text));
        }
    }
}
