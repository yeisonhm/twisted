﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/TwoColumn.Master" Inherits="System.Web.Mvc.ViewPage<MvcApplication1.Dominio.Model.Viaje>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Agregar un nuevo Viaje
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script src="../../MvcApplication1/Scripts/jquery-1.4.3.js"></script>
    <script src="../../MvcApplication1/Scripts/jquery.ui.core.js"></script>
    <script src="../../MvcApplication1/Scripts/jquery.ui.datepicker-es.js"></script>
    <script src="../../MvcApplication1/Scripts/jquery.ui.datepicker.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#fechaInicio").datepicker();
        });
        $(function () {
            $("#fechaFin").datepicker();
        });
	</script>

    <%= Html.ValidationSummary(true,"Ha ocurrido un error. Por favor corrijalos e intente de nuevo.") %>
    <% using (Html.BeginForm()) {%>

        <fieldset>
            <legend>Crear nuevo Viaje:</legend>
            
            <div class="editor-label">
                <label for="Nombre">Nombre:</label>
            </div>
            <div class="editor-field">
            <%= Html.TextBox("Nombre",null, new { @class = "text-box" })%>
            <%= Html.ValidationMessage("Nombre", "*") %>
            </div>
            
            <div class="editor-label">
                <label for="Privacidad"> Privacidad:</label>
            </div>
            <div class="editor-field">
                <%= Html.DropDownList("Privacidad") %>
                <%= Html.ValidationMessage("Privacidad", "*") %>
            </div>

            <div class="editor-label">
                <label for="fechaInicio"> Fecha inicio:</label>
            </div>
            <div class="editor-field">
                <%= Html.TextBox("fechaInicio",null, new { @class = "text-box" })%>
                <%= Html.ValidationMessage("fechaInicio", "*") %>
            </div>

            <div class="editor-label">
                <label for="fechaFin"> Fecha fin:</label>
            </div>
            <div class="editor-field">
                <%= Html.TextBox("fechaFin",null, new { @class = "text-box" })%>
                <%= Html.ValidationMessage("fechaFin", "*") %>
            </div>
            
            <div class="editor-label">
                <label for="Destino"> Destino:</label>
            </div>
            <div class="editor-field">  
                <%= Html.TextBox("Destino",null, new { @class = "text-box" })%>
                <%= Html.ValidationMessage("Destino", "*") %>
            </div>

            <div class="editor-label">
                <label for="Hospedaje"> Hospedaje:</label>
            </div>
            <div class="editor-field">
                <%= Html.TextBox("Hospedaje", null, new { @class = "text-box" })%>
                <%= Html.ValidationMessage("Hospedaje", "*") %>
            </div>
            
            <div class="editor-label">
                <input type="submit" class="ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only ui-state-hover" value="Agregar" />
            </div>
        </fieldset>

    <% } %>

    <div>
    <a title="Volver" href="<%= Url.Action("Index", "Viaje") %>">
          <img src="<%= Url.Content("~/Content/atras.png") %>" height="25px" width="25px" /></a>
        <%: Html.ActionLink("Volver...", "Index") %>
    </div>

</asp:Content>

