'use client'
import {AdminNav} from "@/components/admin/AdminNav";
import {ItemInfo} from "@/components/admin/ItemInfo";
import {useState} from 'react';
import {AdminActions} from "@/types/enum";
import {ProductEdit} from "@/components/admin/ProductEdit";

const Admin = () => {
  const [activeTab, setActiveTab] = useState<AdminActions>(AdminActions.ADD_NEW_PLACE);
  const products = ['', '', '']
  return (
    <div className='pt-[40px] px-[21px] flex flex-col items-center justify-center'>
      <div className='max-w-[1430px] flex border-b-white border-b-2 w-full'>
        <AdminNav
          active={activeTab}
          action={AdminActions.ADD_NEW_PLACE}
          setActiveTab={setActiveTab}
          title='Add new places'
          iconName='plus'
        />
        <AdminNav
          active={activeTab}
          action={AdminActions.EDIT_PLACE}
          setActiveTab={setActiveTab}
          title='Edit places'
          iconName='pencil'
        />
      </div>
      <div className='max-w-[1430px] w-full pt-12'>
        {activeTab === AdminActions.ADD_NEW_PLACE && <ItemInfo/>}
        {activeTab === AdminActions.EDIT_PLACE && (
          <div>
            {products.map((product, index) => (
              <ProductEdit key={index}/>
            ))}
          </div>
        )}
      </div>
    </div>
  );
}

export default Admin;