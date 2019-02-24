# hada-p1

HADA Assignment 1b: Use of GitHub/remote

P1
  The branch that has been uploaded is the master branch.
P2
  When using the Compare option, we get a view of the file before being modified and after,
  with the changes highlighted, so that we can see the changes that have been made.
P3
  We do not see the changes in the remote repository yet because we have not made the push operation,
  so we have only modified our local repository and not the remote one.
P4
  "Confirm in stages" means adding only the selected files to the staging area, and not the whole project.
  The equivalent command would be "git add " + the files.
P5
  "Confirm in stages and insert" means doing the same as with "Confirm in stages", and then make a commit.
  The equivalent comand would be "git add "+ the files and then "git commit -m ..." or, if there are no new
  files and we want to commit the changes of all files, "git commit -a -m ...".
P6
  "Confirm in stages and synchronize" means doing the same as "confirm in stages and insert" and then make
  a push. The equivalent command would be "git add ...", then "git commit ..." and then "git push"
P7
  When we click on Sync, the command we are making is pull, whereas clicking on Extract is the command fetch.
  The difference is that when pulling, we get the remote changes on the local repository and on the working
  copy, whereas when fetching, we only get the remote changes in the local repository.
P8
  "Merge by combination" is equivalent to the command merge, which creates a new commit that combines both
  branches (or just moves the HEAD pointer if there have not been any changes in the master branch).
P9
  "Merge by base change" is equivalent to the command rebase, which adds in the master branch the commits
  made to the other branch next to the last commit made in the master branch.
