module Types 
open System

type Protocol =
    {   ID: Guid
        Name: string
        Description: string
        Focus: string }

type Effect = string
type Command = Effect list
type Card =
    {   ID: Guid
        Protocol: Protocol
        Value: int
        TopCommand:Command
        MiddleCommand:Command
        BottomCommand:Command }