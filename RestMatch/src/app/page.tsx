'use client'

import {imageUrl} from "@/utils/constants";
import InfoItem from "@/components/InfoItem";
import React from "react";
import {useRouter} from "next/navigation";
import {Routes} from "@/types/routes";

export default function Home() {
  const data = [
    {
      title: 'Register or login',
      description: 'fvfkssvkpokvspkopv sflvsvofsvk mvsvsvmf mcs skcmkdmsk ckmmcdk kcsmkcsd j jdcjds mksmc',
      enableButton: true,
      buttonText: "Register",
      url: Routes.SIGN_UP
    },
    {
      title: "Choose preferences",
      description:
        "Quick way to choose where you must go today. Delicious and beautiful places await you",
      enableButton: true,
      buttonText: "Make choice",
      url: Routes.PREFERENCES
    },
    {
      title: "Like or pass",
      description:
        "Quick way to choose where you must go today. Delicious and beautiful places await you",
      enableButton: true,
      buttonText: "Let's match",
      url: Routes.MATCH
    },
    {
      title: 'Don`t like swipe?',
      description: 'Quick way to choose where you must go today. Delicious and beautiful places await you',
      enableButton: true,
      buttonText: "Search",

      url: Routes.SEARCH
    }
  ]

  const router = useRouter();
  const handleRoute = (url: Routes) => {
    router.push(url)
  }

  return (
    <main>
      <div className='flex h-[582px] px-6'>
        <img className='absolute w-full top-0 left-0 right-0 h-[582px] ' src={`${imageUrl}/homepage/home-background.png`} alt="coffee"/>
        <div className='z-10 flex justify-between text-[40px] w-full mt-[80px] font-medium'>
          <h2 className='text-left max-w-[521px]'>Find the best place to hangout with friends or celebrate important event</h2>
          <h2 className='text-right max-w-[500px]'>Quick way to choose where you must go today. Delicious and beautiful places await you</h2>
        </div>
      </div>
      <div className='pt-[55px] px-6'>
        <h2 className='font-bold'>What you need?</h2>
        <hr/>
        <div className='grid gap-2 mt-6 grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4'>
          {data.map((item, index) => (
            <InfoItem
              key={index}
              title={item.title}
              description={item.description}
              buttonText={item.buttonText}
              onClickHandle={() => handleRoute(item.url)}
            />
          ))}
        </div>
      </div>
      <div className=" md:hidden">
        <Carousel data={data} />
      </div>
      <div
        {...swipeHandlers}
        className="hidden relative w-full max-w-md mx-auto overflow-hidden"
      >
        <div
          className="flex transition-transform duration-500 ease-in-out"
          style={{
            transform: `translateX(-${currentIndex * 100}%)`,
            width: `${data.length * 100}%`, // Робимо контейнер ширшим для всіх слайдів
          }}
        >
          {data.map((item, index) => (
            <div
              key={index}
              style={{
                flexBasis: "100%",
              }}
              className={`flex-none w-full h-[400px]carousel-item transition-transform duration-500 ease-in-out transform `}
            >
              <div className="grid gap-4 mt-6 grid-cols-1">
                <InfoItem
                  key={index}
                  title={item.title}
                  description={item.description}
                  buttonText={item.buttonText}
                  onClickHandle={() => handleRoute(item.url)}
                />
              </div>
            </div>
          ))}
        </div>

        {/* Управління */}
        <button
          className="absolute top-1/2 -translate-y-1/2 left-0 bg-white text-black p-2 rounded-full shadow-lg"
          onClick={handlePrev}
        >
          ❮
        </button>
        <button
          className="absolute top-1/2 -translate-y-1/2 right-0 bg-white text-black p-2 rounded-full shadow-lg"
          onClick={handleNext}
        >
          ❯
        </button>
      </div>
      <div className="pt-[80px] pb-[44px] pl-6 pr-6 lg:pr-0">
        <div className="flex relative">
          <div className="flex-[3]">
            <h2 className="font-bold mb-[19px]">
              Want to see place that you liked earlier?
            </h2>
            <p className="leading-9 text-[1.6rem] md:text-[1.875rem]">
              Lorem ipsum dolor sit amet, consectetur adipisicing elit. Hic,
              itaque saepe? Ab aliquam dicta, dolores ea enim eveniet,
              exercitationem facilis fugiat impedit iusto nesciunt quibusdam
              quis rem sint ut vel. Alias asperiores assumenda aut blanditiis
              consequatur consequuntur distinctio doloribus harum ipsa maxime,
              porro quidem ratione repudiandae ullam ut, vero, vitae? Animi

            </p>
            
            <button className='mt-[41px] bg-[#5D462D] py-2 px-9 rounded-[40px] font-bold text-[2rem] w-full md:w-fit'>My saved</button>
          </div>
          <div className='xl:flex-[1] hidden lg:flex justify-end '>
            <img
              src={`${imageUrl}/homepage/coffee-hand.png`}
              className='h-[280px] w-[315px] xl:h-fit xl:w-auto'
              alt="hand with coffe"/>
          </div>
        </div>
      </div>
    </main>
  );
}
