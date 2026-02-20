# PasswordEncryptor
Takes in passwords and encrypts them that way people don't just have your passwords if they get leaked.
It is fairly simply as of right now so it only takes in passwords with numbers and strings no special characters
it can do both uppercase and lowercase however.

It should also be noted that to use this you can just download this file onto your computer and then run it using
any C# ide. From there you can just put in any password in the PasswordEncryption constructor call and it will
print to the console the encrypted version.

Lastly again do NOT put in special characters it will not work. You are free to make a version that can do that,
but this version does not. This password encryption is for sure not the best out there so keep that in mind
if you want to seriously use this. As there are no guarentees that this is even remotly unbreakable, use 
at your own risk.

Side note: since this repo is public anyone who looks at this will be able to decrypt the passwords that are encrypted
with this program. So if you really do want to use this I would highly suggest you make some changes here and there, so
that others cannot just use this as decryptor.
