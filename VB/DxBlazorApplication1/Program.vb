' Add services to the container.
' The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' Configure the HTTP request pipeline.
' TODO: Error SkippedTokensTrivia 'if'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia '{'
' TODO: Error SkippedTokensTrivia ':'
' TODO: Error SkippedTokensTrivia 'true'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '.'
' TODO: Error SkippedTokensTrivia ';'
 ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
var builder = WebApplication.CreateBuilder(args);

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddRazorCo...' at character 290
''' 
''' 
''' Input:
''' 
// Add services to the container.
builder.Services.AddRazorComponents
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 325
''' 
''' 
''' Input:
''' ()
    .
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' AddInteractiveServerComponents();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddDevExpr...' at character 368
''' 
''' 
''' Input:
''' 
builder.Services.AddDevExpressBlazor
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(options ' at character 404
''' 
''' 
''' Input:
''' (options => {

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'options.SizeMode' at character 422
''' 
''' 
''' Input:
'''     options.SizeMode = 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'DevExpress.Blazor.SizeMode....' at character 441
''' 
''' 
''' Input:
''' DevExpress.Blazor.SizeMode.Medium;
});

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddSinglet...' at character 481
''' 
''' 
''' Input:
''' 
builder.Services.AddSingleton<DxBlazorApplication1.Services.Interfaces.IAppointmentService<DxBlazorApplication1.Models.UniversityClass>, ServiceLayer.Implementations.InMemory.InMemoryAppointmentService>
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 683
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddSinglet...' at character 687
''' 
''' 
''' Input:
''' builder.Services.AddSingleton<DxBlazorApplication1.Services.Interfaces.IResourceService<DxBlazorApplication1.Models.Lecturer>, ServiceLayer.Implementations.InMemory.InMemoryResourceService>
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 876
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddSinglet...' at character 880
''' 
''' 
''' Input:
''' builder.Services.AddSingleton<DxBlazorApplication1.Services.Interfaces.ILabelService<DxBlazorApplication1.Models.LectureType>, ServiceLayer.Implementations.InMemory.InMemoryLabelService>
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1066
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddSinglet...' at character 1070
''' 
''' 
''' Input:
''' builder.Services.AddSingleton<DxBlazorApplication1.Services.Interfaces.IStatusService<DxBlazorApplication1.Models.LectureStatus>, ServiceLayer.Implementations.InMemory.InMemoryStatusService>
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1260
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddMvc' at character 1265
''' 
''' 
''' Input:
''' 
builder.Services.AddMvc
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1288
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
var app = builder.Build();

// Configure the HTTP request pipeline.
if 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 1364
''' 
''' 
''' Input:
''' (!
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.Environment.IsDevelopment' at character 1366
''' 
''' 
''' Input:
''' app.Environment.IsDevelopment
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1395
''' 
''' 
''' Input:
''' ()) {

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseExceptionHandler' at character 1405
''' 
''' 
''' Input:
'''     app.UseExceptionHandler
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 1428
''' 
''' 
''' Input:
''' ("/Error", 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'createScopeForErrors' at character 1439
''' 
''' 
''' Input:
''' createScopeForErrors: true);

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseHsts' at character 1604
''' 
''' 
''' Input:
'''     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1615
''' 
''' 
''' Input:
''' ();
}

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseHttpsRedirection' at character 1621
''' 
''' 
''' Input:
''' app.UseHttpsRedirection
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1644
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseStaticFiles' at character 1649
''' 
''' 
''' Input:
''' 
app.UseStaticFiles
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1667
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseAntiforgery' at character 1671
''' 
''' 
''' Input:
''' app.UseAntiforgery
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1689
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.MapRazorComponents<App>' at character 1694
''' 
''' 
''' Input:
''' 
app.MapRazorComponents<App>
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1721
''' 
''' 
''' Input:
''' ()
    .
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' AddInteractiveServerRenderMode()
    .
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' AllowAnonymous();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.Run' at character 1786
''' 
''' 
''' Input:
''' 
app.Run
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1793
''' 
''' 
''' Input:
''' ();
''' 