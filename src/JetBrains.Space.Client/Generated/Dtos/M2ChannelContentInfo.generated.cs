// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public interface M2ChannelContentInfo
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static BillingFeedChannel BillingFeedChannel(ChannelSpecificDefaults? notificationDefaults = null)
        => new BillingFeedChannel(notificationDefaults: notificationDefaults);
    
    public static M2ChannelAutomationJobFeedInfo M2ChannelAutomationJobFeedInfo(JobSubscription jobSubscription, string jobName, ChannelSpecificDefaults notificationDefaults, string? repoName = null)
        => new M2ChannelAutomationJobFeedInfo(jobSubscription: jobSubscription, jobName: jobName, notificationDefaults: notificationDefaults, repoName: repoName);
    
    public static M2ChannelContactObsolete M2ChannelContactObsolete(M2ObsoleteCause? cause = null)
        => new M2ChannelContactObsolete(cause: cause);
    
    public static M2ChannelContentApplication M2ChannelContentApplication(ESApp app, ChannelSpecificDefaults notificationDefaults)
        => new M2ChannelContentApplication(app: app, notificationDefaults: notificationDefaults);
    
    public static M2ChannelContentArticle M2ChannelContentArticle(ArticleRecord article, ArticleContentRecord articleContent, ArticleDetailsRecord? details = null, ArticleChannelRecord? channel = null)
        => new M2ChannelContentArticle(article: article, articleContent: articleContent, details: details, channel: channel);
    
    public static M2ChannelContentCodeDiscussion M2ChannelContentCodeDiscussion(string codeDiscussionId, ChannelSpecificDefaults notificationDefaults, CodeDiscussionRecord? codeDiscussion = null)
        => new M2ChannelContentCodeDiscussion(codeDiscussionId: codeDiscussionId, notificationDefaults: notificationDefaults, codeDiscussion: codeDiscussion);
    
    public static M2ChannelContentCodeReviewDiscussion M2ChannelContentCodeReviewDiscussion(string codeReviewDiscussion, ChannelSpecificDefaults notificationDefaults)
        => new M2ChannelContentCodeReviewDiscussion(codeReviewDiscussion: codeReviewDiscussion, notificationDefaults: notificationDefaults);
    
    public static M2ChannelContentCodeReviewFeed M2ChannelContentCodeReviewFeed(string codeReviewId, ChannelSpecificDefaults notificationDefaults, CodeReviewRecord? codeReview = null, CodeReviewParticipants? participants = null, CodeReviewPendingMessageCounter? pendingMessageCounter = null, PRProject? project = null)
        => new M2ChannelContentCodeReviewFeed(codeReviewId: codeReviewId, notificationDefaults: notificationDefaults, codeReview: codeReview, participants: participants, pendingMessageCounter: pendingMessageCounter, project: project);
    
    public static M2ChannelContentLocation M2ChannelContentLocation(TDLocation location, ChannelSpecificDefaults notificationDefaults)
        => new M2ChannelContentLocation(location: location, notificationDefaults: notificationDefaults);
    
    public static M2ChannelContentMember M2ChannelContentMember(TDMemberProfile member, ChannelSpecificDefaults notificationDefaults, ProfileMembershipRecord? memberTeams = null)
        => new M2ChannelContentMember(member: member, notificationDefaults: notificationDefaults, memberTeams: memberTeams);
    
    public static M2ChannelContentMembership M2ChannelContentMembership()
        => new M2ChannelContentMembership();
    
    public static M2ChannelContentMention M2ChannelContentMention(ChannelItemRecord record, M2ChannelRecord parent)
        => new M2ChannelContentMention(record: record, parent: parent);
    
    public static M2ChannelContentNamedPrivateChannel M2ChannelContentNamedPrivateChannel(string name, bool canHaveThreads, ChannelSpecificDefaults? notificationDefaults = null, PrivateFeedColor? color = null, string? icon = null)
        => new M2ChannelContentNamedPrivateChannel(name: name, canHaveThreads: canHaveThreads, notificationDefaults: notificationDefaults, color: color, icon: icon);
    
    public static M2ChannelContentTeam M2ChannelContentTeam(TDTeam team, ChannelSpecificDefaults notificationDefaults)
        => new M2ChannelContentTeam(team: team, notificationDefaults: notificationDefaults);
    
    public static M2ChannelContentThread M2ChannelContentThread(ChannelItemRecord record, M2ChannelRecord parent)
        => new M2ChannelContentThread(record: record, parent: parent);
    
    public static M2ChannelIssueInfo M2ChannelIssueInfo(Issue issue, ChannelSpecificDefaults notificationDefaults, ProjectKey? projectKey = null)
        => new M2ChannelIssueInfo(issue: issue, notificationDefaults: notificationDefaults, projectKey: projectKey);
    
    public static M2ChannelRdWsTimelineInfo M2ChannelRdWsTimelineInfo(ChannelSpecificDefaults notificationDefaults, string workspaceId, string workspaceName)
        => new M2ChannelRdWsTimelineInfo(notificationDefaults: notificationDefaults, workspaceId: workspaceId, workspaceName: workspaceName);
    
    public static M2PrivateConversationChannelContent M2PrivateConversationChannelContent(string channelId, List<TDMemberProfile> members, string? subject = null, ChannelSpecificDefaults? notificationDefaults = null)
        => new M2PrivateConversationChannelContent(channelId: channelId, members: members, subject: subject, notificationDefaults: notificationDefaults);
    
    public static M2SharedChannelContent M2SharedChannelContent(string name, string group, M2Access access, string description, ChannelSpecificDefaults notificationDefaults, string? iconId = null, List<TDTeam>? teams = null, bool? canEdit = null, PRProject? project = null)
        => new M2SharedChannelContent(name: name, group: group, access: access, description: description, notificationDefaults: notificationDefaults, iconId: iconId, teams: teams, canEdit: canEdit, project: project);
    
    public static SpaceNewsFeedChannel SpaceNewsFeedChannel(ChannelSpecificDefaults? notificationDefaults = null, bool? supportReplies = null)
        => new SpaceNewsFeedChannel(notificationDefaults: notificationDefaults, supportReplies: supportReplies);
    
}

