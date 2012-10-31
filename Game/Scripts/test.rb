require_relative 'twitterModule'
require 'rubygems'
require 'twitter'

class Teste
  extend TwitterModule
  
  t1=Thread.new{listener()}
  sleep 60
  p "test"
  
end