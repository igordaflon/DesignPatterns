﻿namespace DesignPatterns._01___Criacional._1._1___AbstractFactory;

public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();

    IAbstractProductB CreateProductB();
}
