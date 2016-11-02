﻿using UnityEngine;
using System.Collections;

public interface ICommand
{
    void execute();
}

public class MoveCommand : ICommand
{
    private IGameActor actor_;
    private float vert_;
    private float horz_;

    public MoveCommand(IGameActor actor, float vertMove, float horzMove)
    {
        actor_ = actor; 
        vert_ = vertMove;
        horz_ = horzMove;
    }

    public void execute()
    {
        actor_.Move(vert_, horz_);
    }
}
public class AttackCommand : ICommand
{
    private IGameActor actor_;

    public AttackCommand(IGameActor actor)
    {
        actor_ = actor;
    }

    public void execute()
    {
        actor_.Attack();
    }
}
public class BuffCommand : ICommand
{
    private IGameActor actor_;
    private Buff buff_;

    public BuffCommand(IGameActor actor, Buff buff)
    {
        actor_ = actor;
        buff_ = buff;
    }

    public void execute()
    {
        actor_.UseBuff(actor_, buff_);
    }
}