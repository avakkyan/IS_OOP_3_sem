﻿using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab3.Result;
using Itmo.ObjectOrientedProgramming.Lab3.Services;
using Itmo.ObjectOrientedProgramming.Lab3.Tests.Mocks;
using Itmo.ObjectOrientedProgramming.Lab3.User.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.AdresseesType;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;
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
        var messageProxy = new MessageProxy();
        var meaasges = new List<MessageStatus>();
        var user = new MyUser(messageProxy, meaasges);
        IMessage message = myBuilderMessage.
            WithTitle(title).
            WithBody(body).
            WithImportanceLevel(importanceLevel).
            CreateMessage();
        IAddressee userAdressee = new AddresseeUser(user);
        var topic = new Topic.Models.MyTopic(topicName, userAdressee);

        topic.SendMessageFromTopic(message);
        user.GetMessage(message);
        user.ReadMessage(message);
        MessageStatus? messageStatus = meaasges.FirstOrDefault(targetMessage =>
            targetMessage.Message.Body is not null &&
            targetMessage.Message.Body.Equals(message.Body, StringComparison.Ordinal));
        bool messageStatusIsRead = messageStatus is not null && messageStatus.IsRead;
        Assert.True(messageStatusIsRead);
    }

    [Fact]
    public void TestMakeMessageRead()
    {
        string title = "241";
        string body = "time is 241";
        ImportanceLevel importanceLevel = ImportanceLevel.None;
        string topicName = "church of 241";
        var myBuilderMessage = new MyBuilderMessage();
        var messageProxy = new MessageProxy();
        var meaasges = new List<MessageStatus>();
        var user = new MyUser(messageProxy, meaasges);
        Message message = myBuilderMessage.
            WithTitle(title).
            WithBody(body).
            WithImportanceLevel(importanceLevel).
            CreateMessage();
        IAddressee userAdressee = new AddresseeUser(user);
        var topic = new Topic.Models.MyTopic(topicName, userAdressee);

        topic.SendMessageFromTopic(message);
        user.GetMessage(message);
        user.ReadMessage(message);
        MessageStatus? messageStatus = meaasges.FirstOrDefault(targetMessage =>
            targetMessage.Message.Body is not null &&
            targetMessage.Message.Body.Equals(message.Body, StringComparison.Ordinal));
        bool messageStatusIsRead = messageStatus is not null && messageStatus.IsRead;

        Assert.True(messageStatusIsRead);
    }

    [Fact]
    public void TestErrorMakingMessageRead()
    {
        string title = "241";
        string body = "time is 241";
        ImportanceLevel importanceLevel = ImportanceLevel.None;
        string topicName = "church of 241";
        MessageResult result = MessageResult.None;
        var myBuilderMessage = new MyBuilderMessage();
        var messageProxy = new MessageProxy();
        var messages = new List<MessageStatus>();
        var user = new MyUser(messageProxy, messages);
        Message message = myBuilderMessage.
            WithTitle(title).
            WithBody(body).
            WithImportanceLevel(importanceLevel).
            CreateMessage();
        IAddressee userAdressee = new AddresseeUser(user);
        var topic = new Topic.Models.MyTopic(topicName, userAdressee);

        topic.SendMessageFromTopic(message);
        user.GetMessage(message);
        user.ReadMessage(message);
        MessageStatus? messageStatusFirst = messages.FirstOrDefault(targetMessage =>
            targetMessage.Message.Body is not null &&
            targetMessage.Message.Body.Equals(message.Body, StringComparison.Ordinal));
        bool messageStatusIsReadFirst = messageStatusFirst is not null && messageStatusFirst.IsRead;
        if (messageStatusFirst is not null && messageStatusFirst.IsRead)
        {
            result = MessageResult.NotSuccess;
        }
        else
        {
            user.ReadMessage(message);
        }

        MessageResult expectedResult = MessageResult.NotSuccess;
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestMessageFilter()
    {
        string title = "241";
        string body = "time is 241";
        ImportanceLevel importanceLevel = ImportanceLevel.VeryImportant;
        string topicName = "church of 241";
        var myBuilderMessage = new MyBuilderMessage();
        var messageProxy = new MessageProxy();
        var messages = new List<MessageStatus>();
        var user = new MyUser(messageProxy, messages);
        Message message = myBuilderMessage.
            WithTitle(title).
            WithBody(body).
            WithImportanceLevel(importanceLevel).
            CreateMessage();
        IAddressee userAddressee = new AddresseeUser(user);
        IAddressee userMockAdresseeFilter = new AddresseeUserMockTestFour(ImportanceLevel.VeryImportant, userAddressee);
        var topic = new Topic.Models.MyTopic(topicName, userMockAdresseeFilter);

        topic.SendMessageFromTopic(message);
        var adresseeUserMock = (AddresseeUserMockTestFour)topic.Addresee;

        Assert.True(adresseeUserMock.IsRecieved);
    }

    [Fact]
    public void TestLoggingMessage()
    {
        string title = "I am unbreakable";
        string body = "I am dead inside";
        ImportanceLevel importanceLevel = ImportanceLevel.None;
        string topicName = "church of 241";
        var messageProxy = new MessageProxy();
        var messages = new List<MessageStatus>();
        var user = new MyUser(messageProxy, messages);
        var myBuilderMessage = new MyBuilderMessage();
        Message message = myBuilderMessage.
            WithTitle(title).
            WithBody(body).
            WithImportanceLevel(importanceLevel).
            CreateMessage();
        IAddressee userAddressee = new AddresseeUser(user);
        var logger = new LoggerMock();
        IAddressee userMockAddressee = new AdresseeUserMockTestFive(userAddressee, logger);
        var topic = new Topic.Models.MyTopic(topicName, userMockAddressee);

        topic.SendMessageFromTopic(message);
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
        addresseeMessangerMock.GetMessage(message);
        var myMessanger = new MyMessangerMock();
        myMessanger.GetMessage(message);
        string expectingResult = $"New message {message.Body}";
        myMessanger.ShowMessage(message.Body);
        string? mockMessage = myMessanger.MockMessagerMessage;
        Assert.Equal(expectingResult, mockMessage);
    }
}