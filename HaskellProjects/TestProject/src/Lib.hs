module Lib where

infixl 6 :+:
infixl 7 :*:
data Expr = Val Int | Expr :+: Expr | Expr :*: Expr
    deriving (Show, Eq)

expand :: Expr -> Expr
expand prev@((e1 :+: e2) :*: e) = expander prev curr where 
    curr = (expand e1 :*: expand e) :+: (expand e2 :*: expand e)
expand prev@(e :*: (e1 :+: e2)) = expander prev curr where 
    curr = (expand e :*: expand e1) :+: (expand e :*: expand e2)
expand prev@(e1 :+: e2) = expander prev curr where 
    curr = (expand e1 :+: expand e2)
expand prev@(e1 :*: e2) = expander prev curr where 
    curr = (expand e1 :*: expand e2)
expand e = e

expander :: Expr -> Expr -> Expr
expander prev curr = if (prev == curr) then curr else (expander curr (expand curr))

e1 = (Val 1 :+: Val 2)
e2 = (Val 3 :+: Val 4)
e3 = Val 5
e4 = (Val 6 :*: Val 7)
e5 = e3 :*: e1
e6 = e1 :*: e3
e7 = e3 :*: (e3 :+: e3) :*: e3
