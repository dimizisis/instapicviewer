import urllib.request
import json
import sys


def get_user_id(username):

    with urllib.request.urlopen('https://www.instagram.com/web/search/topsearch/?context=user&count=0&query='+username) as url:
        data = json.loads(url.read().decode())

    return data['users'][0]['user']['pk']


def get_image_link(id):

    with urllib.request.urlopen('https://i.instagram.com/api/v1/users/'+id+'/info/') as url:
        data = json.loads(url.read().decode())

    return data['user']['hd_profile_pic_versions'][0]['url']


if __name__ == '__main__':

    user_id = get_user_id(sys.argv[1])

    image_link = get_image_link(user_id)

    print(image_link)