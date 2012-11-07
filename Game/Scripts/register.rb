#require 'mongo'
#require 'mongo_mapper'
#MongoMapper.database="users"
#connection = MongoMapper.connection
#users= connection.db('User')
#connection = users.connection
#connection = MongoMapper.connection
require_relative 'User.rb'
MongoMapper.connection = Mongo::Connection.new('127.0.0.1',27017)
MongoMapper.database = "userdb"

def register
  STDOUT.flush
  #name email username password
  
  name = ARGV[0]
  email = ARGV[1]
  username = ARGV[2]
  password = ARGV[3]
  
  if (User.first(:username => username) ==nil) and (User.first(:email=>email) ==nil)
      user = User.new(:name => name, :email => email, :username => username, :password => password)
      user.save
      p "Bem-vindo",user.name,"seu nome de usuario eh: ",user.username
      return true
  else
      p "Registro falhou"
      return false  
  end 
  
end
register