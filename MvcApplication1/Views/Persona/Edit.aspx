﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcApplication1.Dominio.Model.Persona>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Apellido) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Apellido) %>
                <%: Html.ValidationMessageFor(model => model.Apellido) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Email) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Email) %>
                <%: Html.ValidationMessageFor(model => model.Email) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Estatus) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Estatus) %>
                <%: Html.ValidationMessageFor(model => model.Estatus) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.FechaNacimiento) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.FechaNacimiento, String.Format("{0:g}", Model.FechaNacimiento)) %>
                <%: Html.ValidationMessageFor(model => model.FechaNacimiento) %>
            </div>
            
                       
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Nombre) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Nombre) %>
                <%: Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Privacidad) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Privacidad) %>
                <%: Html.ValidationMessageFor(model => model.Privacidad) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Twitter) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Twitter) %>
                <%: Html.ValidationMessageFor(model => model.Twitter) %>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>
