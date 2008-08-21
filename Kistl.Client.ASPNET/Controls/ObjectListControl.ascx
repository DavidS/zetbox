﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ObjectListControl.ascx.cs" Inherits="Controls_ObjectListControl" %>
<%@ Import Namespace="Kistl.Client.ASPNET.Toolkit" %>
<div class="Control" id="container" runat="server">
    <asp:Label ID="Label1" runat="server" AssociatedControlID="divItems"><%= ShortLabel %></asp:Label>
    <div style="float: left;max-height:200px; overflow: auto;" id="divItems" runat="server">
        <div>
            <a ID="lnkNew" runat="server">New</a>
            <a ID="lnkAdd" runat="server">Add</a>
        </div>
        <adc:DataList ID="lstItems" runat="server" DataKeyField="ID" CssClass="ItemTable">
            <HeaderTemplate>
                <strong>Objects</strong>
            </HeaderTemplate>
            <ItemTemplate>
                <a href="#" commandName="item">Open</a>
                <a href="#" commandName="delete">Remove</a>
                <span id="text"></span>
            </ItemTemplate>
        </adc:DataList>
    </div>
    <asp:HiddenField ID="hdItems" runat="server" />
    <div style="clear: left; height:0px;">
    </div>
</div>