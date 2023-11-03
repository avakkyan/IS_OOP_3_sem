using System;
using Itmo.ObjectOrientedProgramming.Lab3.Mocks;
using Itmo.ObjectOrientedProgramming.Lab3.Result;
using Itmo.ObjectOrientedProgramming.Lab3.Services;
using Itmo.ObjectOrientedProgramming.Lab3.User.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Adapter;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Models;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class Tests
{
    [Fact]
    public void TestNotReadMessage()
    {
        string title = "241";
        string body = "time is 241";
        ImportanceLevel importanceLevel = ImportanceLevel.None;
        string topicName = "church of 241";
        var myBuilderMessage = new MyBuilderMessage();
        Message message = myBuilderMessage.
            WithTitle(title).
            WithBody(body).
            WithImportanceLevel(importanceLevel).
            CreateMessage();
        IAddressee userAdressee = new AddresseeUser();
        var topic = new Topic.Models.MyTopic(topicName, userAdressee);

        topic.SendMessageFromTopic(message);
        var addresseeUser = (AddresseeUser)topic.Addresee;
        var user = (IUser)addresseeUser.MyAddresseeUser;
        bool result = user.CheckNewContains(message);

        Assert.True(result);
    }

    [Fact]
    public void TestMakeMessageRead()
    {
        string title = "241";
        string body = "time is 241";
        ImportanceLevel importanceLevel = ImportanceLevel.None;
        string topicName = "church of 241";
        var myBuilderMessage = new MyBuilderMessage();
        Message message = myBuilderMessage.
            WithTitle(title).
            WithBody(body).
            WithImportanceLevel(importanceLevel).
            CreateMessage();
        IAddressee userAdressee = new AddresseeUser();
        var topic = new Topic.Models.MyTopic(topicName, userAdressee);

        topic.SendMessageFromTopic(message);
        var addresseeUser = (AddresseeUser)topic.Addresee;
        var user = (IUser)addresseeUser.MyAddresseeUser;
        user.ReadMessage(message);
        bool result = user.CheckStoryContains(message);

        Assert.True(result);
    }

    [Fact]
    public void TestErrorMakingMessageRead()
    {
        string title = "241";
        string body = "time is 241";
        ImportanceLevel importanceLevel = ImportanceLevel.None;
        string topicName = "church of 241";
        var myBuilderMessage = new MyBuilderMessage();
        Message message = myBuilderMessage.
            WithTitle(title).
            WithBody(body).
            WithImportanceLevel(importanceLevel).
            CreateMessage();
        IAddressee userAdressee = new AddresseeUser();
        var topic = new Topic.Models.MyTopic(topicName, userAdressee);

        topic.SendMessageFromTopic(message);
        var addresseeUser = (AddresseeUser)topic.Addresee;
        var user = (IUser)addresseeUser.MyAddresseeUser;
        user.ReadMessage(message);
        MessageResult result = user.ReadMessage(message);
        MessageResult expectedResult = MessageResult.NotSuccess;

        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestMessageFilter()
    {
        string title = "241";
        string body = "time is 241";
        ImportanceLevel importanceLevel = ImportanceLevel.None;
        string topicName = "church of 241";
        var myBuilderMessage = new MyBuilderMessage();
        Message message = myBuilderMessage.
            WithTitle(title).
            WithBody(body).
            WithImportanceLevel(importanceLevel).
            CreateMessage();
        IAddressee userAdressee = new AddresseeUserMockTestFour();
        var topic = new Topic.Models.MyTopic(topicName, userAdressee);

        topic.SendMessageFromTopic(message);
        var adresseeUserMock = (AddresseeUserMockTestFour)topic.Addresee;
        adresseeUserMock.GetMessageAdapting(message, ConsoleColor.Black);
        bool expectedResult = false;

        Assert.False(expectedResult);
    }

    [Fact]
    public void TestLoggingMessage()
    {
        string title = "241";
        string body = "time is 241";
        ImportanceLevel importanceLevel = ImportanceLevel.None;
        string topicName = "church of 241";
        var myBuilderMessage = new MyBuilderMessage();
        Message message = myBuilderMessage.
            WithTitle(title).
            WithBody(body).
            WithImportanceLevel(importanceLevel).
            CreateMessage();
        IAddressee userAdressee = new AdresseeUserMockTestFive();
        var topic = new Topic.Models.MyTopic(topicName, userAdressee);

        topic.SendMessageFromTopic(message);
        var adresseeUserMock = (AdresseeUserMockTestFive)topic.Addresee;
        var logger = (LoggerMock)adresseeUserMock.Logger;
        logger.LogMessage(message);
        string expectedResult = $"Message got addressee with title {message?.Title}";

        Assert.Equal(expectedResult, logger.MockLogMessage);
    }

    [Fact]
    public void TestShowMessengerMessage()
    {
        string title = "241";
        string body = "time is 241";
        ImportanceLevel importanceLevel = ImportanceLevel.None;
        string topicName = "church of 241";
        var myBuilderMessage = new MyBuilderMessage();
        Message message = myBuilderMessage.
            WithTitle(title).
            WithBody(body).
            WithImportanceLevel(importanceLevel).
            CreateMessage();
        IAddressee userAdressee = new AddresseeMessangerMock();
        var topic = new Topic.Models.MyTopic(topicName, userAdressee);

        topic.SendMessageFromTopic(message);
        var addresseeMessangerMock = (AddresseeMessangerMock)topic.Addresee;
        addresseeMessangerMock.GetMessageAdapting(message, ConsoleColor.Black);
        var myMessanger = new MyMessangerMock();
        myMessanger.GetMessage(message);
        string expectingResult = $"New message {message.Body}";
        myMessanger.ShowMessage(message.Body);
        string? mockMessage = myMessanger.MockMessagerMessage;
        Assert.Equal(expectingResult, mockMessage);
    }
}