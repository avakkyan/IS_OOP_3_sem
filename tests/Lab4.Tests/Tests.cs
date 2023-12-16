using Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab4.Tests;

public class Tests
{
    [Fact]
    public void TestParcerDisconnect()
    {
        var linkConnect = new LinkConnect();
        var linkDisconnect = new LinkDisconnect();
        var linkFile = new LinkFile();
        var linkTree = new LinkTree();
        linkConnect.AddNext(linkDisconnect);
        linkDisconnect.AddNext(linkFile);
        linkFile.AddNext(linkTree);

        string myCommand = "disconnect";
        var request = new MyRequest(myCommand);

        string address = "connect C:// -m local";
        var requestFirst = new MyRequest(address);
        linkConnect.Handle(requestFirst);
        var disconnectCommand = (Disconnect?)linkConnect.Handle(request);
        Assert.Equal(string.Empty, disconnectCommand?.CommandValueAddress);
    }

    [Fact]
    public void TestParcerConnect()
    {
        var linkConnect = new LinkConnect();
        var linkDisconnect = new LinkDisconnect();
        var linkFile = new LinkFile();
        var linkTree = new LinkTree();
        linkConnect.AddNext(linkDisconnect);
        linkDisconnect.AddNext(linkFile);
        linkFile.AddNext(linkTree);

        string myCommand = "connect C:// -m local";
        var request = new MyRequest(myCommand);

        string address = "C://";
        var requestFirst = new MyRequest(address);
        linkConnect.Handle(requestFirst);
        var connectCommand = (Connect?)linkConnect.Handle(request);
        Assert.Equal(address, connectCommand?.CommandValueAddress);
    }

    [Fact]
    public void TestParcerLinkFileRename()
    {
        var linkConnect = new LinkConnect();
        var linkDisconnect = new LinkDisconnect();
        var linkFile = new LinkFile();
        var linkTree = new LinkTree();
        linkConnect.AddNext(linkDisconnect);
        linkDisconnect.AddNext(linkFile);
        linkFile.AddNext(linkTree);

        string myCommand = "file rename C:// a";
        var request = new MyRequest(myCommand);

        string address = "C://";
        var requestFirst = new MyRequest(address);
        linkConnect.Handle(requestFirst);
        var fileRenameCommand = (FileRename?)linkConnect.Handle(request);
        string expectedAddress = "a";
        Assert.Equal(expectedAddress, fileRenameCommand?.NameValue);
    }
}