#require 'mongo'
#require 'mongo_mapper'
#MongoMapper.database="users"
#connection = MongoMapper.connection
#users= connection.db('User')
#connection = users.connection
#connection = MongoMapper.connection
require_relative 'User.rb'


def register
  STDOUT.flush
  #name email username password
  
  name = ARGV[0]
  email = ARGV[1]
  username = ARGV[2]
  password = ARGV[3]
  
  if (User.first(:username => username) ==nil) or (User.first(:email=>email) ==nil)
      users = Connection.new.db('usersConnection')
      posts = db.collection('usersColl')
      user = { :name => name, :email => email, :username => username, :password => password }
      user_id = users.insert(user)
      p "Bem-vindo",newUser.name,"seu nome de usuario eh: ",newUser.username
      return true
  else
      p "pokdpaoksd"
      return false  
  end 

end
register