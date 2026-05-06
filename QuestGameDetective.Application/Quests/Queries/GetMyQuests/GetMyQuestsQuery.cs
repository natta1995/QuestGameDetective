using MediatR;
using QuestGameDetective.Application.Dtos.Quest;
using QuestGameDetective.Application.Dtos.Quests;

namespace QuestGameDetective.Application.Quests.Queries.GetMyQuests;

public record GetMyQuestsQuery(string UserId) : IRequest<List<MyQuestDto>>;