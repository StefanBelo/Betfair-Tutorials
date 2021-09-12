# Place Bet
## AllowPlacingBetInPlay
If you want to allow bet placing when a market is in-play then set this parameter to True.
## AtInPlayKeepBet
When market is turned at in-play all unmatched bets are canceled by betfair. Setting this parameter to True will keep your bets on the market. Betfair does not support keep the bet option for all in-play markets.
## BetType
The type of your bet, back or lay.
## Odds
The odds you want to place your bet at. If you want to place your bet on the exact odds set the parameter PlaceBetInAllowedOddsRange to False.
## MinimumOdds
Minimum odds you are willing to take. When you set this parameter you must set the parameter PlaceBetInAllowedOddsRange to True.
## MaximumOdds
Maximum odds you are willing to take. When you set this parameter you must set the parameter PlaceBetInAllowedOddsRange to True.
## PlaceBetInAllowedOddsRange
Set to True if you want to place your bet in allowed odds range only. One of parameters MinimumOdds or MaximumOdds must be set too.
## MinimumOddsDifference
The minimum odds difference (between best offer lay odds and best offered back odds, in ticks) to place your bet.
## MaximumOddsDifference
The maximum odds difference (between best offer lay odds and best offered back odds, in ticks) to place your bet.
## OfferMyBet
Set to True if you want to offer your bet on an opposite bet side. When backing your bet will be offered on the best lay odds.
## PriceImprovement
Improve your odds (price). For instance if you back a selection offering your bet and the best lay odds is 2.02 then PriceImprovement parameter set to 1 will adjust your odds to 2.04.
## ChaseOddsTimeout
If your bet is not fully matched and odds changes the bot chases the offered odds. You can postpone the odds chasing setting this timeout parameter.
## Stake
Your stake amount you want to bet. When laying your liability is different, to lay with the stake liability set the parameter StakeType to Liability.
## StakeType
Stake type: Stake, Liability, TickProfit, NetTickProfit
## PlaceBetAtTime
Place bet at time. The time span is calculated from the official event start time. If you set this parameter to -0:05:00 then your bet will be placed 5 minutes before the official event start time. The positive value 0:05:00 means that your bet will be placed 5 minutes after the event start time.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Be the First in Queue
## AllowPlacingBetInPlay
If you want to allow bet placing when a market is in-play then set this parameter to True.
## AtInPlayKeepBet
When market is turned at in-play all unmatched bets are canceled by betfair. Setting this parameter to True will keep your bets on the market. Betfair does not support keep the bet option for all in-play markets.
## BetType
The type of your bet, back or lay.
## MinimumOdds
Minimum odds you are willing to take. When you set this parameter you must set the parameter PlaceBetInAllowedOddsRange to True.
## MaximumOdds
Maximum odds you are willing to take. When you set this parameter you must set the parameter PlaceBetInAllowedOddsRange to True.
## PlaceBetInAllowedOddsRange
Set to True if you want to place your bet in allowed odds range only. One of parameters MinimumOdds or MaximumOdds must be set too.
## MinimumOddsDifference
The minimum odds difference (between best offer lay odds and best offered back odds, in ticks) to place your bet.
## MaximumOddsDifference
The maximum odds difference (between best offer lay odds and best offered back odds, in ticks) to place your bet.
## PriceImprovement
Improve your odds (price). For instance if you back a selection offering your bet and the best lay odds is 2.02 then PriceImprovement parameter set to 1 will adjust your odds to 2.04.
## MinimumBetStakeToChase
If your bet is not fully matched and odds changes the bot chase the odds so your bet would be always the first in the queue. You can avoid the odds chasing for bet offers which stake amount is less than value set by this parameter.
## ChaseOddsTimeout
If your bet is not fully matched and odds changes the bot chases the offered odds. You can postpone the odds chasing setting this timeout parameter.
## Stake
Your stake amount you want to bet. When laying your liability is different, to lay with the stake liability set the parameter StakeType to Liability.
## StakeType
Stake type: Stake, Liability, TickProfit, NetTickProfit
## PlaceBetAtTime
Place bet at time. The time span is calculated from the official event start time. If you set this parameter to -0:05:00 then your bet will be placed 5 minutes before the official event start time. The positive value 0:05:00 means that your bet will be placed 5 minutes after the event start time.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Fill or Kill
## AtInPlayKeepBet
When market is turned at in-play all unmatched bets are canceled by betfair. Setting this parameter to True will keep your bets on the market. Betfair does not support keep the bet option for all in-play markets.
## BetType
The type of your bet, back or lay.
## Odds
The odds you want to place your bet at. Set to 0 when you want to offer your bet at best offered odds.
## Stake
Your stake amount you want to bet. When laying your liability is different, to lay with the stake liability set the parameter StakeType to Liability.
## StakeType
Stake type: Stake, Liability, TickProfit, NetTickProfit
## BetMatchingTimeout
If your bet is not fully matched, the bet will be cancelled after this timeout expires.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Close Selection Bet Position
## ProfitLossType
Set your profit and loss target type: money, ticks or percentage.
## Profit
The profit target at which you want to close your bet position.
## Loss
The loss target at which you want to close your bet position.
## HedgingEnabled
Set to True if you want to hedge your bet position.
## WaitForValidBetPosition
If set to True bot will wait for valid bet position to be opened.
## CheckingLastPriceTraded
Set to True if you want to check if offered price was really matched in price range set by the parameter: CheckingLastPriceTradedDifference.
## CheckingLastPriceTradedDifference
Set allowed price/odds difference in ticks from the last price traded when closing bet position in loss.
## OfferMyBet
Set to True if you want to offer your bet on an opposite bet side. When backing your bet will be offered on the best lay odds.
## ClosePositionImmediately
Set this parameter to True if you want to place your closing bet immediately.
## BetMatchingTimeout
If your bet is not fully matched, the bet will be cancelled after this timeout expires.
## ClosePositionAtTime
Close your bet position at time. The time span is calculated from the official event start time. If you set this parameter to -0:05:00 then your bet position will be closed 5 minutes before the official event start time. The positive value 0:05:00 means that your bet will be closed 5 minutes after the event start time.
## UseShareBetPosition
Use the shared bet position.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Close Selection Bet Position at Odds
## Odds
The profit target at which you want to close your bet position.
## HedgingEnabled
Set to True if you want to hedge your bet position.
## CheckingLastPriceTraded
Set to True if you want to check if offered price was really matched in price range set by the parameter: CheckingLastPriceTradedDifference.
## CheckingLastPriceTradedDifference
Set allowed price/odds difference in ticks from the last price traded when closing bet position in loss.
## BetMatchingTimeout
If your bet is not fully matched, the bet will be cancelled after this timeout expires.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Place Bet and Close Selection Bet Position
## OpenBetPosition
## AllowPlacingBetInPlay
If you want to allow bet placing when a market is in-play then set this parameter to True.
## AtInPlayKeepBet
When market is turned at in-play all unmatched bets are canceled by betfair. Setting this parameter to True will keep your bets on the market. Betfair does not support keep the bet option for all in-play markets.
## BetType
The type of your bet, back or lay.
## Odds
The odds you want to place your bet at. If you want to place your bet on the exact odds set the parameter PlaceBetInAllowedOddsRange to False.
## MinimumOdds
Minimum odds you are willing to take. When you set this parameter you must set the parameter PlaceBetInAllowedOddsRange to True.
## MaximumOdds
Maximum odds you are willing to take. When you set this parameter you must set the parameter PlaceBetInAllowedOddsRange to True.
## PlaceBetInAllowedOddsRange
Set to True if you want to place your bet in allowed odds range only. One of parameters MinimumOdds or MaximumOdds must be set too.
## MinimumOddsDifference
The minimum odds difference (between best offer lay odds and best offered back odds, in ticks) to place your bet.
## MaximumOddsDifference
The maximum odds difference (between best offer lay odds and best offered back odds, in ticks) to place your bet.
## OfferMyBet
Set to True if you want to offer your bet on an opposite bet side. When backing your bet will be offered on the best lay odds.
## PriceImprovement
Improve your odds (price). For instance if you back a selection offering your bet and the best lay odds is 2.02 then PriceImprovement parameter set to 1 will adjust your odds to 2.04.
## ChaseOddsTimeout
If your bet is not fully matched and odds changes the bot chases the offered odds. You can postpone the odds chasing setting this timeout parameter.
## Stake
Your stake amount you want to bet. When laying your liability is different, to lay with the stake liability set the parameter StakeType to Liability.
## StakeType
Stake type: Stake, Liability, TickProfit, NetTickProfit
## PlaceBetAtTime
Place bet at time. The time span is calculated from the official event start time. If you set this parameter to -0:05:00 then your bet will be placed 5 minutes before the official event start time. The positive value 0:05:00 means that your bet will be placed 5 minutes after the event start time.
## CloseBetPosition
## ProfitLossType
Set your profit and loss target type: money, ticks or percentage.
## Profit
The profit target at which you want to close your bet position.
## Loss
The loss target at which you want to close your bet position.
## HedgingEnabled
Set to True if you want to hedge your bet position.
## CheckingLastPriceTraded
Set to True if you want to check if offered price was really matched in price range set by the parameter: CheckingLastPriceTradedDifference.
## CheckingLastPriceTradedDifference
Set allowed price/odds difference in ticks from the last price traded when closing bet position in loss.
## OfferMyBet
Set to True if you want to offer your bet on an opposite bet side. When backing your bet will be offered on the best lay odds.
## ClosePositionImmediately
Set this parameter to True if you want to place your closing bet immediately.
## BetMatchingTimeout
If your bet is not fully matched, the bet will be cancelled after this timeout expires.
## ClosePositionAtTime
Close your bet position at time. The time span is calculated from the official event start time. If you set this parameter to -0:05:00 then your bet position will be closed 5 minutes before the official event start time. The positive value 0:05:00 means that your bet will be closed 5 minutes after the event start time.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Tick Offset
## BetType
The type of your bet, back or lay.
## Odds
The odds you want to place your bet at. Set to 0 when you want to offer your bet at best offered odds.
## Stake
Your stake amount you want to bet. When laying your liability is different, to lay with the stake liability set the parameter StakeType to Liability.
## StakeType
Stake type: Stake, Liability, TickProfit, NetTickProfit
## Profit
The profit target at which you want to close your bet position.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Scratch Trading
## Stake
Your stake amount you want to bet. When laying your liability is different, to lay with the stake liability set the parameter StakeType to Liability.
## StakeType
Stake type: Stake, Liability, TickProfit, NetTickProfit
## Liquidity
Trigger bet placing when on both sides there is offered amount.
## Scratch
Scratch the trade if on the closing bet position there is offered amount.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Trailing Stop Loss
## Loss
The number of ticks to prevent further loss of a profitable bet position. Once a bet position losses its best profit position then your bet position is closed, but only when in a profit.
## HedgingEnabled
Set to True if you want to hedge your bet position.
## BetMatchingTimeout
If your bet is not fully matched, the bet will be cancelled after this timeout expires.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Close Market Bet Position
## Profit
The profit target at which you want to close your bet position.
## Loss
The loss target at which you want to close your bet position.
## ProfitOrLossInPercentage
Set this parameter to True if you want to use percentage values for profit and loss targets.
## WaitForValidBetPosition
If set to True bot will wait for valid bet position to be opened.
## BetMatchingTimeout
If your bet is not fully matched, the bet will be cancelled after this timeout expires.
## CheckingLastPriceTraded
Set to True if you want to check if offered price was really matched in price range set by the parameter: CheckingLastPriceTradedDifference.
## CheckingLastPriceTradedDifference
Set allowed price/odds difference in ticks from the last price traded when closing bet position in loss.
## ClosePositionAtTime
Close your bet position at time. The time span is calculated from the official event start time. If you set this parameter to -0:05:00 then your bet position will be closed 5 minutes before the official event start time. The positive value 0:05:00 means that your bet will be closed 5 minutes after the event start time.
## AllowBotExecutionTermination
Set to True if you allow the bot execution termination before closing the market bet position.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Execute on Selections
## BotName
The bot name you want to execute.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## OnSelections
Selections on which you want to execute your bot (for instance: 1,2,4). If you do not type any selections the action bot will be execute on all selections.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Execute Bots
## BotNames
The bot names you want to execute (for instance: bot1;bot2).
## UseLadderParameters
Use the ladder parameters: BetType, Price and Stake to update your action bot.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Execute on Associated Market
## BotName
The bot name you want to execute.
## MarketName
Set if you want to execute the action bot on an associated market, for instance: OVER_UNDER_25.
## ExecutionTimeout
Set to postpone the bot execution.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Execute Till Target Profit
## BotName
The bot name you want to execute.
## TargetProfit
The bot executes your action bot till the target profit is reached.
## TargetLoss
The bot executes your action bot till the target loss is reached.
## ResetStakingPlan
Reset the staking plan after loses.
## MartingaleStakeFactor
Add previous loses to my stake.
## ExecuteAtTime
If set the action bot will be executed at time span calculated from the official event start time. If you set this parameter to -0:05:00 then your bet will be placed 5 minutes before the official event start time. The positive value 0:05:00 means that your bet will be placed 5 minutes after the event start time.
## StopExecutionAtTime
If a previous betting result is not known till this time the bot will stop its execution.
## StrategyID
Use to assign the unique strategy identification for concurrently executed strategies.
## UseShowResultSummary
Show the result summary for diagnostic purposes.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# If Then Else
## IfThenCriteria
Set criteria to execute the bot set by the parameter IfThenBotName.
## IfThenBotName
If criteria set by the parameter IfThenCriteria are evaluated to be True, the bot is executed.
## IfElseCriteria
Set criteria to execute the bot set by the parameter IfElseBotName.
## IfElseBotName
If criteria set by the parameter IfElseCriteria are evaluated to be True, the bot is executed.
## EvaluateIfCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the "If" criteria only once.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Sequence Execution
## BotNames
The bot names you want to execute (for instance: bot1;bot2).
## ShareBetPosition
Use the shared bet position.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Concurrent Execution
## BotNames
The bot names you want to execute (for instance: bot1;bot2).
## EndExecutionIfAnyBotEnds
Force the rest of action bots execution to be ended, if any of bots ends its execution.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Repeat Until
## BotName
The bot name you want to execute.
## RepeatUntilParameter
The condition type evaluated for each iteration until target value is reached.
## TargetValue
The target value, see the parameter: RepeatUntilParameter.
## NextIterationTimeout
Set to postpone the next iteration.
## StopAtTime
Stop the repeat operation at the time. The time span is calculated from the official event start time. If you set this parameter to -0:05:00 then repeat operation will be stopped 5 minutes before the official event start time. The positive value 0:05:00 means that repeat operation will be stopped 5 minutes after the event start time.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Execute Trigger Bot
## TriggerParameters
The bot trigger parameters, for instance: Stake:100.0;BetType:BetType.Back
## TriggerFilePathName
The bot trigger full file path name, for instance: C:\MyTriggers\MyTestTriger.dll
## BotName
The bot name you want to execute.
## UseLadderParameters
Use the ladder parameters: BetType, Price and Stake to update your action bot.
## UseMyStrategyResults
Use my strategy results.
## AllowBotExecutionTermination
Set to True if you allow the bot execution termination.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Football Bot
## BotName
The bot name you want to execute.
## MarketName
Set if you want to execute the action bot on an associated market, for instance: OVER_UNDER_25.
## StartCriteria
Set the start criteria to be evaluated to trigger the action bot execution set by the parameter BotName. The criteria parameters are: MatchTime, Score and ScoreDifference. The score values are in the following format: 2 - 1
## StopCriteria
Set the stop criteria to be evaluated to stop football bot execution. The criteria parameters are: MatchTime, Score and ScoreDifference. The score values are in the following format: 2 - 1
## ExecutionTimeout
Set to postpone the bot execution.
## ShowScore
Show score in the output view for diagnostic purposes.
## ShowMatchCriteria
Show the match criteria in the output view for diagnostic purposes.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Tennis Bot
## BotName
The bot name you want to execute.
## ExecuteOnPlayer
Execute the action bot on the player.
## PointsScore
The points score (the mandatory parameter) to trigger the action bot you set by parameter: BotName.
## GamesScore
The games score to trigger the action bot you set by parameter: BotName.
## SetsScore
The sets score to trigger the action bot you set by parameter: BotName.
## PreviousSetIndex
The previous set index, for instance 1 for the first set, if not used set to 0.
## PreviousSetGamesScore
The previous set games score to trigger the action bot you set by parameter: BotName.
## ScoreUpdateInterval
The score update interval in seconds.
## UseWebApi
Use the betfair web api to update live score data.
## ShowScore
Show score in the output view for diagnostic purposes.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Stop Bots and Cancel Bets
## StopRunningBots
Set to True if you want to stop all running bots and cancel unmatched bets.
## StopAtTime
Stop market monitoring at time. The time span is calculated from the official event start time. If you set this parameter to -0:05:00 then your bet will be placed 5 minutes before the official event start time. The positive value 0:05:00 means that your bet will be placed 5 minutes after the event start time.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Trailing Stop Loss on Market
## Loss
The trailing stop loss to prevent further loss of a profitable bet position. Once a bet position losses its best profit position then your bet position is closed, but only when in a profit.
## ProfitOrLossInPercentage
Set this parameter to True if you want to use percentage values for profit and loss targets.
## WaitForValidBetPosition
If set to True bot will wait for valid bet position to be opened.
## BetMatchingTimeout
If your bet is not fully matched, the bet will be cancelled after this timeout expires.
## ClosePositionAtTime
Close your bet position at time. The time span is calculated from the official event start time. If you set this parameter to -0:05:00 then your bet position will be closed 5 minutes before the official event start time. The positive value 0:05:00 means that your bet will be closed 5 minutes after the event start time.
## ShowDebugInfo
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Cancel Bots on Selection
## BotNames
The bot names you want to cancel (for instance: bot1;bot2).
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Place Dutching Bets
## BetType
The type of your bet, back or lay.
## TargetValue
Set the target value, so required profit or total stake depending on what you set by parameter: DutchingType.
## ChaseOddsTimeout
If your bet is not fully matched and odds changes the bot chases the offered odds. You can postpone the odds chasing setting this timeout parameter.
## DutchingType
Set the dutching type, required profit or total stake.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## NumberOfSelections
Set the number of selections you want to dutch.
## OnSelections
Selections on which you want to place dutch bets (for instance: 1,2,4). If you do not type any selections the selections will be defined by parameter: NumberOfSelections.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Execute at Time
## BotName
The bot name you want to execute.
## TimeSpanType
Set to RelativeToStartTime if you want to start the action bot at time relative to the official market start time.
## StartTimeSpan
Start the bot execution at the time. The time span is calculated from the official event start time. If you set this parameter to -0:05:00 then repeat operation will be stopped 5 minutes before the official event start time. The positive value 0:05:00 means that repeat operation will be stopped 5 minutes after the event start time.
## StopTimeSpan
Stop the bot execution at the time. The time span is calculated from the official event start time. If you set this parameter to -0:05:00 then repeat operation will be stopped 5 minutes before the official event start time. The positive value 0:05:00 means that repeat operation will be stopped 5 minutes after the event start time.
## UseExecuteImmediately
Set to True if you want to execute the action bot immediately without evaluating TimeSpanType and StartTimeSpan parameters.
## UseExecuteOnNewMarketsOnly
Set to True if you want to execute the action bot only on new markets. Use this parameter when executing your action bots by "Market Auto Open" tool.
## UseSetMarketInactive
When the bot is executed in the Bot Executor tool then setting market inactive state will open the market in the Bet Event view.
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
# Place SP Bet
## BetType
The type of your bet, back or lay.
## Odds
The odds you want to place your bet at. If you want to place your bet on the exact odds set the parameter PlaceBetInAllowedOddsRange to False.
## LimitOdds
The limit odds for your SP bet. Bets are matched if, and only if, the returned starting price is better than a specified price. In the case of back bets, LOC bets are matched if the calculated starting price is greater than the specified price. In the case of lay bets, LOC bets are matched if the starting price is less than the specified price.
## PersistenceType
The bet persistence: Cancel, Keep or Take SP.
## Stake
Your SP bet stake liability.
## StakeType
Stake type: Stake, Liability, TickProfit, NetTickProfit
## SortSelectionsBy
Set to sort selections by last traded price or total matched volume.
## ExecuteOnSelection
The selection on which you want to execute your bot. If set to 0 the bot is executed on the active selection in the market grid view. If set to 1 .. X, the bot is executed on X favorite or X selection depending on how you set the parameter SortSelectionsBy.
## EvaluateEntryCriteriaOnlyOnce
Set this parameter to True if you want to evaluate the entry criteria only once.
## StopMarketMonitoring
Set this parameter to True if you want to stop the market monitoring after the bot stops its execution. The market monitoring is stopped only when no other bot is active on the market.
## StrategyReference
Set to specify which strategy has sent the bet. The string is limited to 15 characters.
