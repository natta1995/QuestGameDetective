using MediatR;
using QuestGameDetective.Application.Dtos.Quest;

namespace QuestGameDetective.Application.Quests.Queries.GetMyQuests;

public record GetMyQuestsQuery(string UserId) : IRequest<List<MyQuestDto>>;