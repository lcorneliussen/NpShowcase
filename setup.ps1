cls
$root = Split-Path (Resolve-Path $myInvocation.MyCommand.Path);
$svnRepo = Join-Path $root "svn-repository"
$checkout = Join-Path $root "checkout"
$svnUrl = 'file:///' + $svnRepo.Replace("\", "/")
$mvnRepo = Join-Path $root "mvn-repository"
$localRepoNpShowcase =  Join-Path $Env:Home .m2\repository\NpShowcase

# Cleanup SVN stuff
if (test-path $svnRepo -pathType container) {
  echo "# deleting $svnRepo"
  del $svnRepo -r -force
  
  echo "# deleting .svn files in $checkout"
  gci $checkout -include .svn -r -force | 
   Remove-Item -r -force
}

# Cleanup staging Maven-Repository stuff
if (test-path $mvnRepo -pathType container) {
  echo "# deleting $mvnRepo"
  del $mvnRepo -r -force
}

# Cleanup local Maven-Repository stuff
if (test-path $localRepoNpShowcase -pathType container) {
  echo "# deleting $localRepoNpShowcase"
  del $localRepoNpShowcase -r -force
}

echo "# creating mvn-repository"
mkdir $mvnRepo | out-null

# Set up SVN
echo "# creating svn-repository"
svnadmin create $svnRepo

echo "# checking out from svn-repository"
svn checkout $svnurl $checkout

echo "# switch to checkout dir"
cd $checkout
svn add *
svn commit -m "Initial commit"
svn status

cd $root