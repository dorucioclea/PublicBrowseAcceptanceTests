﻿namespace NHSDPublicBrowseAcceptanceTests.TestData.Utils
{
     internal static class Queries
    {
        internal const string CreateNewSolution = "INSERT INTO Solution (Id, OrganisationId, Name, Version, PublishedStatusId, AuthorityStatusId, SupplierStatusId, OnCatalogueVersion) values (@solutionId, 1000000, @solutionName, @solutionVersion, 1,1,1, 0)";
        internal const string GetSolution = "SELECT Summary, FullDescription, SupplierStatusId from [dbo].[Solution] where Id=@solutionId";
        internal const string DeleteSolution = "DELETE from Solution where Id=@solutionId";

        internal const string GetSolutionsCount = "SELECT COUNT (*) as count FROM [dbo].Solution WHERE Solution.PublishedStatusId = 3";
        internal const string GetFoundationSolutionsCount = "SELECT COUNT (*) as count FROM [dbo].Solution LEFT JOIN FrameworkSolutions ON Solution.Id = FrameworkSolutions.SolutionId WHERE COALESCE(FrameworkSolutions.IsFoundation, 0) = 1 AND Solution.PublishedStatusId = 3";
        internal const string GetNonFoundationSolutionsCount = "SELECT COUNT (*) as count FROM [dbo].Solution WHERE Solution.Id NOT IN ( SELECT SolutionId FROM [dbo].FrameworkSolutions WHERE IsFoundation = 1 ) AND Solution.PublishedStatusId = 3";
        internal const string GetSolutionsWithCapabilityCount = "SELECT COUNT(*) as count FROM [dbo].[SolutionCapability] AS sc LEFT JOIN .[dbo].[Capability] AS c ON c.Id = sc.CapabilityId WHERE Name = @capabilityName";
        
        internal const string GetSingleSolution = "SELECT Sol.[Id],Sol.[Name],Sol.[LastUpdated],Det.[AboutUrl],Det.[Summary],Det.[FullDescription],Org.[Name] as SupplierName,RTrim(Coalesce(MC.FirstName + ' ','') + Coalesce(MC.LastName + ' ', '')) as ContactName,MC.[PhoneNumber],MC.[Email],MC.[Department] FROM [dbo].[Solution] as Sol LEFT JOIN [dbo].[SolutionDetail] as Det ON Det.[Id] = Sol.[SolutionDetailId] LEFT JOIN [dbo].[Organisation] as Org ON Sol.OrganisationId = Org.Id LEFT JOIN [dbo].[MarketingContact] as MC ON Sol.Id = MC.SolutionId WHERE Sol.Id = @solutionId";
        internal const string GetSingleSolutionCapabilities = "SELECT STRING_AGG(CAPS.Name, ',') as Capabilities FROM Capability as CAPS Where CAPS.Id in (SELECT CapabilityId FROM SolutionCapability as SC where SC.SolutionId = @solutionId )";
        internal const string GetSingleSolutionMarketingContact = "";
    }
}
